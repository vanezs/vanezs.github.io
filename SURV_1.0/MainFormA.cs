using System;
using Word = Microsoft.Office.Interop.Word;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Microsoft.Office.Interop.Word;

namespace SURV_1._0
{
    public partial class MainFormA : Form
    {
        public MainFormA()
        {
            InitializeComponent();

        }

        private void MainFormA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_SurvDataSet.dateBio". При необходимости она может быть перемещена или удалена.
            this.dateBioTableAdapter.Fill(this.bD_SurvDataSet.dateBio);

            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            SqlCommand command = new SqlCommand("SELECT Login FROM dateBio", cn); //Команда выбора данных
            cn.Open(); //Открываем соединение
            SqlDataReader read = command.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                listBox1.Items.Add(read.GetValue(0).ToString()); //Добавляем данные в лист итем
            }


        }

        private void Show_Person_Click(object sender, EventArgs e)
        {
            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            string FIO = listBox1.Text;

            SqlCommand cmd6 = new SqlCommand("SELECT * FROM dateBio WHERE Login='" + FIO + "'", cn);

            if (cn.State == ConnectionState.Closed) //Open your sql connection if closed
                cn.Open();

            SqlDataReader sqlReader6 = cmd6.ExecuteReader();

            if (sqlReader6.HasRows)
            {
                System.Data.DataTable dt = new System.Data.DataTable();

                System.Data.DataTable dt1 = new System.Data.DataTable();

                dt.Load(sqlReader6);

                dt1 = dt.DefaultView.ToTable(true, "Id", "Login", "CurrentDate", "ComingToWork", "First_Id", "Second_Id", "Third_Id", "Fourth_Id", "Fifth_Id", "Beginning_Lunch", "End_Lunch", "Sixth_Id", "Seventh_id", "Eighth_Id", "Ninth_Id", "Tenth_Id", "Leaving_Work", "KeyW", "Quantity_Id", "KPRV");

                dataGridView1.DataSource = dt1;
            }

            sqlReader6.Close();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT FaceImage FROM FaceImage WHERE Login='" + FIO + "'", cn));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new byte[0];
                data = (Byte[])(dataSet.Tables[0].Rows[0]["FaceImage"]);
                MemoryStream mem = new MemoryStream(data);
                Image FaceImage = Image.FromStream(mem);

                pictureBox1.Image = FaceImage;
                FaceImage.Save("face.jpg");
            }


        }

        // создаем пользователя
        private void Add_Person_Click(object sender, EventArgs e)
        {
            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();


            if (textBox3.Text != string.Empty || textBox4.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from LoginTable where Login='" + textBox3.Text + "'", cn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    MessageBox.Show("Имя пользователя уже существует, выберите другой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string pathF = "id.txt";
                    string readText = File.ReadAllText(pathF);
                    int check = int.Parse(readText);

                    if (System.IO.File.ReadAllText(pathF) == "")
                    {
                        System.IO.File.WriteAllText(pathF, "2");
                        check = 2;
                    }
                    else
                    {
                        check += 1;
                        File.WriteAllText(pathF, check.ToString());
                    }

                    reader.Close();
                    cmd = new SqlCommand("insert into LoginTable values(@Login,@Password,@Id)", cn);
                    cmd.Parameters.AddWithValue("Login", textBox3.Text);
                    cmd.Parameters.AddWithValue("Password", textBox4.Text);
                    cmd.Parameters.AddWithValue("Id", check);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Вы зарегистрированы! Пожалуйста войдите в систему", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста введите значения во все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Person_Click(object sender, EventArgs e)
        {
            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            DialogResult dialogResult = MessageBox.Show("Действительно удалить запись в БД?", "Удаление контракта", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete FROM dateBio WHERE Login='" + textBox3.Text + "'", cn);
                cmd = new SqlCommand("Delete FROM LoginTable WHERE Login='" + textBox3.Text + "'", cn);
                cmd = new SqlCommand("Delete FROM FaceImage WHERE Login='" + textBox3.Text + "'", cn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Отменено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Login_Click(object sender, EventArgs e)
        {

            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            if (textBox7.Text == textBox8.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET Login=" + textBox7.Text + " WHERE Login='" + textBox3.Text + "'", cn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Логины не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Person_Click(object sender, EventArgs e)
        {
            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            if (textBox5.Text == textBox6.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET Password=" + textBox5.Text + " WHERE Password='" + textBox4.Text + "'", cn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 



        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        private void createTable(object sender, EventArgs e)
        {

            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            string[] findWord = { "[1]", "[2]", "[3]", "[4]", "[5]", "[6]", "[7]", "[8]", "[9]", "[10]", "[11]", "[12]", "[13]", "[14]", "[15]",
            "[16]", "[17]", "[18]", "[19]", "[20]", "[21]", "[22]", "[23]", "[24]", "[25]", "[26]", "[27]", "[28]", "[29]", "[30]", "[31]"};

            int days = 0;
            int chour = 0;
            int dayInMonth = 0;


            string name = _nameTable.Text;
            int month = int.Parse(_mounth.Text);
            string monthS = month.ToString();

            if (month < 10)
                monthS = "0" + monthS;


            int year = int.Parse(_year.Text);

            switch (month)
            {
                case 1: dayInMonth = 31; break;
                case 2: dayInMonth = 28; break;
                case 3: dayInMonth = 31; break;
                case 4: dayInMonth = 30; break;
                case 5: dayInMonth = 31; break;
                case 6: dayInMonth = 30; break;
                case 7: dayInMonth = 31; break;
                case 8: dayInMonth = 31; break;
                case 9: dayInMonth = 30; break;
                case 10: dayInMonth = 31; break;
                case 11: dayInMonth = 30; break;
                case 12: dayInMonth = 31; break;
            };



            //createDocX();

            object fileName = Directory.GetCurrentDirectory() + "\\T13.docx";
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application { Visible = true };
            Microsoft.Office.Interop.Word.Document aDoc = wordApp.Documents.Open(fileName, ReadOnly: false, Visible: true);

            string saveTo = Directory.GetCurrentDirectory() + "\\TEST.docx";
            aDoc.SaveAs2(saveTo);

            aDoc = wordApp.Documents.Open(saveTo, ReadOnly: false, Visible: true);
            
            string pathF = "id.txt";
            string readText = File.ReadAllText(pathF);
            int check = int.Parse(readText) - 1;

            aDoc.Activate();
            FindAndReplace(wordApp, "[name]", _nameTable.Text); // готово
            FindAndReplace(wordApp, "[номер]", check.ToString());
            FindAndReplace(wordApp, "[дата]", DateTime.Now.ToString("dd.MM.yyyy"));
            FindAndReplace(wordApp, "[нач. дата]", "01" + "." + monthS + "." + _year.Text);
            FindAndReplace(wordApp, "[кон. дата]", dayInMonth.ToString() + "." + monthS + "." + _year.Text);
            FindAndReplace(wordApp, "[дНП]", DateTime.Now.ToString("dd")); //
            FindAndReplace(wordApp, "[дНК]", DateTime.Now.ToString("dd")); //
            FindAndReplace(wordApp, "[мес]", monthS); // готово
            
            ////// заполнение часов в табеле

            cn.Open();
            for (int i = 1; i < dayInMonth + 1; i++)
            {
                string checkDate;
                string iS = i.ToString();
                if (i < 10)
                    iS = "0" + iS;

                checkDate = i.ToString() + '.' + month.ToString() + '.' + year.ToString();


                //DateTime formate = DateTime.ParseExact(checkDate, "dd.MM.yyyy", new CultureInfo("ru-RU"));
                DateTime formate = Convert.ToDateTime(checkDate);

                SqlCommand cmdDoc = new SqlCommand("select CurrentDate from dateBio where CurrentDate='" + formate.ToString("yyyy.MM.dd") + "'", cn);

                SqlDataReader reader = cmdDoc.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        FindAndReplace(wordApp, findWord[i - 1].ToString(), "8");
                        days++;
                        chour += 8;
                        reader.Close();
                        cmdDoc.ExecuteNonQuery();
                    }
                    else
                    {
                        FindAndReplace(wordApp, findWord[i - 1].ToString(), "-");
                    }

                }
                finally { reader.Close(); }


                if (i < 15)
                {
                    FindAndReplace(wordApp, "[дни1]", days.ToString());
                    FindAndReplace(wordApp, "[часО1]", chour.ToString());
                    FindAndReplace(wordApp, "[час1]", chour.ToString());
                }
                else if (i > 15)
                {
                    FindAndReplace(wordApp, "[дни2]", days.ToString());
                    FindAndReplace(wordApp, "[часО2]", chour.ToString());
                    FindAndReplace(wordApp, "[час2]", chour.ToString());
                }

                if (i == 15)
                {
                    days = 0;
                    chour = 0;
                }



                var _ = System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + "\\TEST.docx");
            }

        }
    }
}

