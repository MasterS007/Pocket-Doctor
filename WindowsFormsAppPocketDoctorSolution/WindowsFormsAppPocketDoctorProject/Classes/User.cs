using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Classes;

namespace WindowsFormsAppPocketDoctorProject
{
     internal class User
    {
        private static int serialNo =1;
        private string userId;
        private string userName;
        private string password;
        private string mobileNumber;


        internal User(string userName, string password, string mobileNumber)
        {
            serialNo += serialNo;
            this.UserId = (serialNo).ToString("0000");
            this.UserName = userName;
            this.Password = password;
            this.MobileNumber = mobileNumber;
        }

        internal virtual string UserId
        {
            get { return this.userId; }
            set
            { this.userId = "U-" + value; }

        }
        internal  string UserName
        {
            get { return this.userName; }
            set {this.userName = value; }

        }
        internal  string Password
        {
            get { return this.password; }
            set
            {   //if(value.Length<6)
                //{
                  //  Console.WriteLine("Password must be more than or equals to 6 characters");
                //}
                //else
                //{
                  this.password = value;
                //}
                
            }

        }
        internal string MobileNumber
        {
            get { return this.mobileNumber; }
            set
            {
               // if(value.Length< mobileNumber.Length || value[0]!=0 )
               // {
                //    Console.WriteLine("Invalid Phone Number");
               // }
               // else
               // {
                    this.mobileNumber = value;
               // }
            }
        }

        public bool InsertUser(User users)
        {
            bool isSucceed = false;
            DatabaseConnection db = new DatabaseConnection();
            SqlConnection conn = db.ConnectDB();

            try
            {
                string sql = "INSERT INTO tbl_USER (userId, userName, password, mobileNumber) VALUES (@userId, @userName , @password,  @mobileNumber)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@userId", this.UserId);
                cmd.Parameters.AddWithValue("@userName", users.UserName);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@mobileNumber", users.MobileNumber);


                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucceed = true;
                    Console.WriteLine("Row INSERTED");
                }
                else
                {
                    isSucceed = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { conn.Close(); }

            return isSucceed;
        }


    }
}
