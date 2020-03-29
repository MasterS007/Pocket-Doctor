using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Classes;


namespace WindowsFormsAppPocketDoctorProject
{
     internal class User
    {
        
        private string userId;
        private string userName;
        private string password;
        private string mobileNumber;
        private string role;
        private static ushort serialNo = 1;

        internal User() { }
        internal User(string userName, string password, string mobileNumber,string role)
        {   
            this.UserName = userName;
            this.Password = password;
            this.MobileNumber = mobileNumber;
            this.Role = role;
            this.UserId = (serialNo++).ToString("0000");
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

        internal string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }



        int rows = 0;
        int rowsup = 0;
        public bool InsertUser(User users)
        {
            bool isSucceed = false;
            //i++;
            DatabaseConnection db = new DatabaseConnection();
            SqlConnection conn = db.ConnectDB();
            
            try
            {
                string sql = "INSERT INTO tbl_USER (id, name, password, mobilenumber,role) VALUES (@userId, @userName , @password, @mobileNumber,@role)";
                SqlCommand cmd = new SqlCommand(sql,conn);
               // SqlDataAdapter adapter = new SqlDataAdapter();
               // adapter.InsertCommand =new SqlCommand(sql, conn);
                
                
                cmd.Parameters.AddWithValue("@userId", this.UserId);
                cmd.Parameters.AddWithValue("@userName",users.UserName);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@mobileNumber",users.MobileNumber);
                cmd.Parameters.AddWithValue("@role", users.Role);
                //cmd.ExecuteNonQuery();

               // int[] rows = new int[] { };
                  
                   rows = cmd.ExecuteNonQuery();
                rowsup++;
                       
                      if (rows==rowsup)
                      {
                         isSucceed = true;
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

        public DataTable SelectUser(User users)
        {
            DatabaseConnection db = new DatabaseConnection();
            SqlConnection conn = db.ConnectDB();
            DataTable dataTable = new DataTable();

            try
            {
                //bool correct = false;
                string sql = "SELECT userId, password FROM tbl_USER WHERE userId=@userId and password=@password";
                
                SqlCommand cmd = new SqlCommand(sql,conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                adapter.Fill(dataTable);

               /* if(dataTable.Rows.Count == 1)
                {
                    correct = true;
                }
                else
                {
                    correct = false;
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { conn.Close(); }
            return dataTable;

        }


    }
}
