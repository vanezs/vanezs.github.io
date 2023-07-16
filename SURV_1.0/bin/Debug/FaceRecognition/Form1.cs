using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace SURV_1._0_FaceRecognizer
{
    public partial class Form1 : Form
    {
        #region Variables

        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();
        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();
        string nameBio = null;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void _btnCapture_Click(object sender, EventArgs e)
        {
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            //videoCapture.ImageGrabbed += ProcessFrame;
            //videoCapture.Start();
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //выводим изображение

            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(_picCapture.Width, _picCapture.Height, Inter.Cubic);

                // Поиск лиц по каскадному классификатору
                if (facesDetectionEnabled)
                {
                    //конвертируем Bgr в gray изображение
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);

                    //Улучшаем изображение для получения лучшего результата
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                    //Если найдено лицо:
                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            //Рисуем квадрат в рамках найденного лица
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);

                            //Добавить лицо в базу
                            //Выводим найденное лицо (изображение) в блок изображения для найденных лиц
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            _picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                            _picDetected.Image = resultImage.ToBitmap();

                            if (EnableSaveImage)
                            {
                                //Создадим каталог, где будем сохранять лица
                                string path = Directory.GetCurrentDirectory() + @"\TraynedImages";
                                if (!Directory.Exists(path))
                                {
                                    Directory.CreateDirectory(path);
                                }
                                //Далее сохраним 1 полученное изображение лица
                                //Для повышения произовдительности будем использовать несколько задач в потоке
                                Task.Factory.StartNew(() =>
                                {
                                    resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + _txtPersonName.Text + ".jpg");
                                    Thread.Sleep(1000);
                                });
                            }
                            EnableSaveImage = false;

                            if (_btnAddPersone.InvokeRequired)
                            {
                                _btnAddPersone.Invoke(new ThreadStart(delegate
                                {
                                    _btnAddPersone.Enabled = true;
                                }));
                            }

                            // Распознование лица
                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox1.Image = grayFaceResult.Bitmap;
                                pictureBox2.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);

                                // Выводим результат найденных лиц
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar, 2);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Неизвестное лицо", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                                }
                            }
                        }
                    }

                }

                //рендерим видео изображение с камеры в блок изображения
                _picCapture.Image = currentFrame.Bitmap;
            }

            if (currentFrame != null)
            {
                currentFrame.Dispose();
            }

        }

        private void _btnDetectFaces_Click(object sender, EventArgs e)
        {
            string filePath = "TextFileLogin.txt";
            string loginName = File.ReadAllText(filePath);
            facesDetectionEnabled = true;
        }

        private void _btnAddPersone_Click(object sender, EventArgs e)
        {
            _btnAddPersone.Enabled = false;
            EnableSaveImage = true;
        }

        //тренировка
        private void _btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        public bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();

            try
            {
                string path = Directory.GetCurrentDirectory() + @"\TraynedImages";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, Byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);
                    nameBio = name;

                }

                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;

                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Ошибка при обучении" + ex.Message);
                return false;

            }
        }

        public bool GetingNamePersone(string nameDefault)
        {
            if (nameBio == nameDefault)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
