using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SURV_1._0
{
    public class ActionOnDataBase
    {
        public SqlConnection connection ()
        {
            string pathToDB = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BD_Surv.mdf");
            //string pathToDB = Path.Combine(@"D:\FULLBILD V0.5 testDB\SURV_1.0", "BD_Surv.mdf"); //для тестирования
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + pathToDB + ";Integrated Security=False");

            return cn;
        }

    }
}
