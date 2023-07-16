using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using SURV_1._0_FaceRecognizer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using ZedGraph;

namespace SURV_1._0
{
    public partial class MainFormS : Form
    {
        int click = 0; // количество раз клика (отметки)

        static ActionOnDataBase DataBase = new ActionOnDataBase();
        SqlConnection cn = DataBase.connection();


        public MainFormS()
        {
            InitializeComponent();

            GUISetting setGUI = new GUISetting();
            setGUI.setLabell(label1);
            setGUI.setLabell(label2);
            setGUI.setLabell(label3);
            setGUI.setLabell(label4);
            setGUI.setLabell(label5);
            setGUI.setLabell(label6);
            setGUI.setLabell(label7);
            setGUI.setLabell(label8);
            setGUI.setLabell(label9);
            setGUI.setLabell(label10);
            setGUI.setLabell(label11);
            setGUI.setLabell(label12);
            setGUI.setLabell(label13);
            setGUI.setLabell(label14);
            setGUI.setLabell(label15);
            setGUI.setLabell(label16);
            setGUI.setLabell(label17);
            setGUI.setLabell(label18);
            


            string filePath = "TextFileLogin.txt";
            string readAllFile = File.ReadAllText(filePath);
            label5.Text = readAllFile;
            cn.Open();

            Time();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\KeyHook\KeyHook.exe");
            searchProccess();
        }

        //определяем текущие время и дату
        public void Time()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("HH:mm:ss");
            label4.Text = DateTime.Now.ToString("dd:MM:yyyy");

        }

        //проверяем биометрические данные
        private void Bio_aut_Click(object sender, EventArgs e)
        {
            Register bio = new Register("fastAut",null,null); // создаем объект модуля распознования лица
            click++;

            bio.ShowDialog();
            if (bio.GetingNamePersone())
            {
                setAutorisation(click);
            }
        }

        private void DBSet(int click, float checkKPRV)
        {
            SqlCommand nowDate = new SqlCommand("select * from dateBio", cn);

            string keylenght = System.IO.File.ReadAllText("WriteText.txt").Length.ToString();

            nowDate = new SqlCommand("insert into dateBio values(@Id, @Login, @CurrentDate, @ComingToWork, " +
                "@First_Id, @Second_Id, @Third_Id, @Fourth_Id, @Fifth_Id, @Beginning_Lunch, @End_Lunch, " +
                "@Sixth_Id, @Seventh_id, @Eighth_Id, @Ninth_Id, @Tenth_Id, @Leaving_Work, @KeyW, " +
                "@Quantity_Id, @KPRV)", cn);

            string pathF = "id.txt";
            string readText = File.ReadAllText(pathF);
            int check = int.Parse(readText);

            nowDate.Parameters.AddWithValue("Id", check);
            nowDate.Parameters.AddWithValue("Login", label5.Text);
            nowDate.Parameters.AddWithValue("CurrentDate", DateTime.ParseExact(label4.Text, "dd:MM:yyyy", CultureInfo.InvariantCulture)); 
            nowDate.Parameters.AddWithValue("ComingToWork", DateTime.ParseExact(g1.Text, "HH:mm", CultureInfo.InvariantCulture)); 
            nowDate.Parameters.AddWithValue("First_Id", DateTime.ParseExact(g3.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Second_Id", DateTime.ParseExact(g6.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Third_Id", DateTime.ParseExact(g9.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Fourth_Id", DateTime.ParseExact(g12.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Fifth_Id", DateTime.ParseExact(g15.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Beginning_Lunch", DateTime.ParseExact(g14.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("End_Lunch", DateTime.ParseExact(g16.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Sixth_Id", DateTime.ParseExact(g18.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Seventh_id", DateTime.ParseExact(g21.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Eighth_Id", DateTime.ParseExact(g24.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Ninth_Id", DateTime.ParseExact(g27.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Tenth_Id", DateTime.ParseExact(g30.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("Leaving_Work", DateTime.ParseExact(g29.Text, "HH:mm", CultureInfo.InvariantCulture));
            nowDate.Parameters.AddWithValue("KeyW", keylenght);
            nowDate.Parameters.AddWithValue("Quantity_Id", click);
            nowDate.Parameters.AddWithValue("KPRV", checkKPRV);

            nowDate.ExecuteNonQuery();
        }

        private void Get_indicators_Click(object sender, EventArgs e)
        {
            Form indicator = new indicators();
            indicator.Show();
        }

        private void MainFormS_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitApplication();
        

        }

        void ExitApplication()
        {
            const string message = "Вы действительно хотите выйти?";
            const string caption = "ВЫХОД";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Закрываем KeyHook
                Process[] localByName = Process.GetProcessesByName("KeyHook");
                foreach (Process p in localByName)
                {
                    p.Kill();
                }
                Application.Exit(); // выход из программы
            }
            else if (result == DialogResult.No)
            {
                //this.Close();
            }
        }

        public void searchProccess()
        {
            Process[] localByName = Process.GetProcessesByName("KeyHook");
            foreach (Process p in localByName)
                label17.Text = "KeyHook (work)";
            label18.Text = System.IO.File.ReadAllText("WriteText.txt").Length.ToString();

        }

        public void setAutorisation(int kubap) 
        {
            int keylenght = System.IO.File.ReadAllText("WriteText.txt").Length;
            float KPRV = (((keylenght / (3500f * 8f)) * (float)(kubap/10f)) / (8f * 9f))*100;
            
            switch (kubap)
            {
                    case 1:
                        g1.Text = DateTime.Now.ToString("HH:mm");
                        g3.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 1";
                        break;
                    case 2:
                        g6.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 2";
                        break;
                    case 3:
                        g9.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 3";
                        break;
                    case 4:
                        g12.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 4";
                        break;
                    case 5:
                        g14.Text = DateTime.Now.ToString("HH:mm");
                        g15.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 5";
                        break;
                    case 6:
                        g18.Text = DateTime.Now.ToString("HH:mm");
                        g16.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 6";
                        break;
                    case 7:
                        g21.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 7";
                        break;
                    case 8:
                        g24.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 8";
                        break;
                    case 9:
                        g27.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 9";
                        break;
                    case 10:
                        g29.Text = DateTime.Now.ToString("HH:mm");
                        g30.Text = DateTime.Now.ToString("HH:mm");
                        label7.Text = "КУБАП: 10";

                        DBSet(kubap, KPRV);
                        MessageBox.Show("Спасибо за работу!", "Конец рабочего дня", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExitApplication();
                        break;
            }

            label6.Text = "КПРВ*: " + $"{KPRV:f1}";

            Bio_aut.Hide();
            _ = showButton(60000 * 60); // 60000 * 60 - час

            searchProccess();

        }

        public async Task showButton(int millisecondsDelay) // асинхронный метод позволяющий каждй час активировать кнопку авторизации
        {
            //await Task.Delay(3600000);
            await Task.Delay(millisecondsDelay);
            Bio_aut.Show();
        }

        //конец определения и вывода в форму
    }
}

