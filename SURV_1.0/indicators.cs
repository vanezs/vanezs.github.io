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
using OpenTK.Input;

namespace SURV_1._0
{
    public partial class indicators : Form
    {
        public indicators()
        {
            InitializeComponent();

            GUISetting setGUI = new GUISetting();
            setGUI.setLabell(label1);

            string filePath = "TextFileLogin.txt";
            string readAllFile = File.ReadAllText(filePath);
            label1.Text = readAllFile;

            ActionOnDataBase DataBase = new ActionOnDataBase();
            SqlConnection cn = DataBase.connection();

            SqlCommand cmd6 = new SqlCommand("SELECT * FROM dateBio WHERE Login='" + label1.Text + "'", cn);

            if (cn.State == ConnectionState.Closed) //Open your sql connection if closed
                cn.Open();

            SqlDataReader sqlReader6 = cmd6.ExecuteReader();

            if (sqlReader6.HasRows)

            {
                DataTable dt = new DataTable();

                DataTable dt1 = new DataTable();

                dt.Load(sqlReader6);

                dt1 = dt.DefaultView.ToTable(true, "Login", "CurrentDate", "ComingToWork", "First_Id", "Second_Id", "Third_Id", "Fourth_Id", "Fifth_Id", "Beginning_Lunch", "End_Lunch", "Sixth_Id", "Seventh_id", "Eighth_Id", "Ninth_Id", "Tenth_Id", "Leaving_Work", "KeyW", "Quantity_Id", "KPRV");

                dataGridView1.DataSource = dt1;
            }
        }
    }
}

