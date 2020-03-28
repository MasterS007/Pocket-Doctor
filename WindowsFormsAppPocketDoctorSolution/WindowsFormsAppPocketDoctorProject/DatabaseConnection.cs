using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsAppPocketDoctorProject
{
    internal class DatabaseConnection 
    {
        internal string UserId { get; set; }
        internal string UserName { get; set; }
        internal string Password { get; set; }
        internal string MobileNumber { get; set; }

        public static string myConnection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
       // public DatabaseConnection db;
        private SqlConnection conn;
       /*  public DatabaseConnection()
        {
             conn = new SqlConnection(myConnection);
             conn.Open();
            Console.WriteLine("DATAbase Conneced");

        }*/
        public DatabaseConnection() { }

        public bool Insert(DatabaseConnection db)
        {
          
            bool isSucceed = false;
            conn = new SqlConnection(myConnection);

            try
            {
                string sql = "INSERT INTO tbl_USER (userId, userName, password, mobileNumber) VALUES (@UserId, @UserName , @Password,  @MobileNumber)";
                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@UserId", db.UserId);
                cmd.Parameters.AddWithValue("@UserName", db.UserName);
                cmd.Parameters.AddWithValue("@Password",db. Password);
                cmd.Parameters.AddWithValue("@MobileNumber",db. MobileNumber);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSucceed = true;
                    Console.WriteLine("Row INSERTED");
                }
                else
                {
                    isSucceed = false;
                }

            }
           catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { conn.Close(); }

            return isSucceed;
        }
    }
    
}
