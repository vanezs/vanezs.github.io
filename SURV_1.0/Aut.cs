using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Emgu.CV.Face;
using SURV_1._0_FaceRecognizer;
using System.Threading;
using System.Diagnostics;
using SURV_1._0.BD_SurvDataSetTableAdapters;

namespace SURV_1._0
{
    public partial class Aut : Form
    {
        static ActionOnDataBase DataBase = new ActionOnDataBase();
        SqlConnection cn = DataBase.connection();

        public Aut()
        {
            InitializeComponent();

        }

        private void Aut_Load(object sender, EventArgs e)
        {
            cn.Open();
            GUISetting setGUI = new GUISetting();
            setGUI.setLabell(label1);
            setGUI.setLabell(label2);
            setGUI.setLabell(label3);

        }

        public void Log_in_Click(object sender, EventArgs e) //авторизация
        {

            if (loginTbox.Text != string.Empty || passwordTbox.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from LoginTable where Login='" + loginTbox.Text + "' and Password='" + passwordTbox.Text + "'", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();

                    if (loginTbox.Text == "Admin" || passwordTbox.Text == "Admin")
                    {

                        this.Hide();
                        MainFormA mainFormA = new MainFormA();
                        mainFormA.ShowDialog();
                        
                    }
                    else
                    {
                        Register bio = new Register("logIn", loginTbox.Text, passwordTbox.Text);
                        bio.ShowDialog();


                        if (bio.GetingNamePersone() == true)
                        {
                            this.Hide();
                            string filePath = "TextFileLogin.txt";
                            File.WriteAllText(filePath, loginTbox.Text);
                            MainFormS mainFormS = new MainFormS();
                            mainFormS.Show();
                        }
                            
                        
                        
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Неверные логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Text = "Ошибка";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста введите значения во все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Text = "Ошибка";
            }


        }


        public void Sign_in_Click(object sender, EventArgs e) //регистрация
        {

            if (loginTbox.Text != string.Empty || passwordTbox.Text != string.Empty)
            {
                registery();
            }
            else
            {
                MessageBox.Show("Пожалуйста введите значения во все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Text = "Ошибка";
            }

            
        }

        private void registery()
        {
            SqlCommand cmd = new SqlCommand("select * from LoginTable where Login='" + loginTbox.Text + "'", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            string filePath = "TextFileLogin.txt";
            File.WriteAllText(filePath, loginTbox.Text);

            if (reader.Read())
            {
                reader.Close();
                MessageBox.Show("Имя пользователя уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string defaultname = loginTbox.Text;
                Debug.WriteLine("Искомое лицо: " + defaultname);


                Register bio = new Register("reg", loginTbox.Text, passwordTbox.Text);
                bio.ShowDialog();

                if (bio.GetingNamePersone() == true)
                {
                  
                    MessageBox.Show("Вы зарегистрированы! Пожалуйста войдите в систему", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log.Text = "Регистрация";
              
                    reader.Close() ;
                }
                else
                {
                    MessageBox.Show("Просим пройти повторную авторизацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    reader.Close();
                }

            }
 
        }
        
    }

}
