using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Classes
{
    public class DatabaseConnection
    {
        public static string myConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DatabaseConnection()
        {

        }

        public SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection(myConnection);
            conn.Open();
            return conn;
        }
    }
}
