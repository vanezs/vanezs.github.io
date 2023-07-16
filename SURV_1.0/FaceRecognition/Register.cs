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
using System.Drawing.Drawing2D;
using SURV_1._0;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Collections;
//using Microsoft.Office.Interop.Word;

namespace SURV_1._0_FaceRecognizer
{
    public partial class Register : Form
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
        private string typeWindow;
        bool saveTrue = false;
        string thisLogin;
        string thisPassword;
        #endregion


        public Register(string type, string login, string password)
        {
            InitializeComponent();

            thisLogin = login;
            thisPassword = password;
            typeWindow = type;

            GUISetting setGUI = new GUISetting();
            setGUI.setLabell(label1);
            setGUI.setLabell(label2);
            

            status.Text = "Откройте камеру";

            switch (typeWindow)
            {
                case "reg":
                    saveTrue = true;
                    break;
                case "logIn":
                    _btnAddPersone.Hide();
                    break;
                case "fastAut":
                    _btnCapture.Hide();
                    _btnDetectFaces.Hide();
                    _btnTrain.Hide();
                    _btnAddPersone.Hide();
                    _picDetected.Hide();
                    pictureBox1.Hide();
                    pictureBox2.Hide();
                    _txtPersonName.Hide();
                    textBox1.Hide();
                    Size size = new Size(1168,655);
                    _picCapture.Size = size;
                    _btnCapture_Click(null, null);
                    _btnDetectFaces_Click(null, null);
                    _btnTrain_Click(null, null);
                    status.Text = "Ожидате распознание лица";
                    label1.Hide();
                    label2.Hide();
                    break;
            }
                
        }

        private void _btnCapture_Click(object sender, EventArgs e)
        {
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            //videoCapture.ImageGrabbed += ProcessFrame;
            //videoCapture.Start();
            Application.Idle += ProcessFrame;
            status.Text = "начните \n поиск лица";
        }



        private void ProcessFrame(object sender, EventArgs e)
        {
            bool check = false; // переменная для UI (проверка на факт найденного лица)
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
                                string path = Directory.GetCurrentDirectory() + @"\FaceRecognition\TraynedImages";
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
                                //Debug.WriteLine(result.Label + ". " + result.Distance);

                                // Выводим результат найденных лиц
                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar, 2);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                    textBox1.Text = PersonsNames[result.Label];
                                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 4);
                                    Debug.WriteLine("найдено лицо: " + textBox1.Text);

                                    if (textBox1.Text == _txtPersonName.Text && textBox1.Text.Length > 0 && check == false)
                                    {
                                        check = true;
                                        status.Text = "Аутентификация пройдена, закройте окно";
                                        status.BackColor = Color.Green;

                                        if (saveTrue)
                                            saveInDB();
                                    }

                                }
                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Неизвестное лицо", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                    if (textBox1.Text != _txtPersonName.Text && textBox1.Text.Length > 0 && check == false)
                                    {
                                        status.Text = "Аутентификация не пройдена";
                                        status.BackColor = Color.Red;
                                    }
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
            string filePath = Directory.GetCurrentDirectory() + @"\TextFileLogin.txt";
            string loginName = File.ReadAllText(filePath);
            _txtPersonName.Text = loginName;
            facesDetectionEnabled = true;

            if (typeWindow != "logIn")
                status.Text = "начните \n распознование лица";
            else if (typeWindow == "reg")
                status.Text = "Зарегистрируйте лицо";

        }

        private void _btnAddPersone_Click(object sender, EventArgs e)
        {
            _btnAddPersone.Enabled = false;
            EnableSaveImage = true;
            status.Text = "начните \n распознование лица";

        }

        public bool GetingNamePersone()
        {
            if (textBox1.Text == _txtPersonName.Text && textBox1.Text != "") return true;
            else return false;
        }

        //тренировка
        private void _btnTrain_Click(object sender, EventArgs e)
        {
            //if(Work)
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
                string path = Directory.GetCurrentDirectory() + @"\FaceRecognition\TraynedImages";
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

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoCapture.Stop();
            videoCapture.Dispose();
            Application.Idle -= ProcessFrame;

            //this.Close();
            
        }

        private void saveInDB()
        {
            string pathF = "id.txt";
            int check = 1;

            if (System.IO.File.ReadAllText(pathF) != "")
            {
                string readText = File.ReadAllText(pathF);
                check = int.Parse(readText) + 1;
                File.WriteAllText(pathF, check.ToString());
            }
            else
            {
                check += 1;
                File.WriteAllText(pathF, check.ToString());
                string readText = File.ReadAllText(pathF);
                check = int.Parse(readText);
            }

            ActionOnDataBase DB = new ActionOnDataBase();
            SqlConnection cn = DB.connection();
            cn.Open();

            SqlCommand cmd = new SqlCommand("insert into LoginTable values(@Id, @Login, @Password)", cn); //Команда выбора данных

            cmd.Parameters.AddWithValue("Id", check);
            cmd.Parameters.AddWithValue("Login", thisLogin);
            cmd.Parameters.AddWithValue("Password", thisPassword);

            cmd.ExecuteNonQuery();

            byte[] imageData = null;

            using(var ms = new MemoryStream()) 
            {
                _picDetected.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }

            SqlCommand command = new SqlCommand("insert into FaceImage values(@Id, @Login, @FaceImage)", cn); //Команда выбора данных
            command.Parameters.AddWithValue("Id", check);  
            command.Parameters.AddWithValue("Login", thisLogin);
            command.Parameters.AddWithValue("FaceImage", SqlDbType.VarBinary).Value = imageData;
            command.ExecuteNonQuery();
            cn.Close();

            saveTrue = false;
             
        }
    }
}