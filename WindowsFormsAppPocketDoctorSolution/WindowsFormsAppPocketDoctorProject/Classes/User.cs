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
        
        private int userId;
        private string userName;
        private string password;
        private string mobileNumber;
        private string role;
        // private static ushort serialNo = 1;

        DatabaseConnection db = new DatabaseConnection();
        

        internal User() { }

      /*  internal void GetId()
        {
            DataSet st = new DataSet();
            SqlConnection conn = db.ConnectDB();
            try
            {
                string sql = "SELECT ISNULL(MAX(id),0)+1 FROM tbl_User";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(st);

                int id = Convert.ToInt32(cmd.ExecuteScalar());
                this.UserId = "U-" + id.ToString("0000"); ;
                
               
            }
            catch (Exception ex)
            { Console.WriteLine(ex); }

            finally { conn.Close(); }
            
        }*/
        internal User(string userName, string password, string mobileNumber,string role)
        {   
            this.UserName = userName;
            this.Password = password;
            this.MobileNumber = mobileNumber;
            this.Role = role;
        }
        internal User(int userId) { this.UserId = userId; }

        internal virtual int UserId
        {
            get { return this.userId; }
             set
             {
              this.userId =  value;
              }

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
        public bool InsertUser(User users)
        {
            SqlConnection conn = db.ConnectDB();
            bool isSucceed = false;
          
            try
            {
                string sql = "INSERT INTO tbl_User ( name, password, mobilenumber,userrole) VALUES ( @userName , @password, @mobileNumber, @userrole)";
                SqlCommand cmd = new SqlCommand(sql, conn);
   
                // SqlDataAdapter adapter = new SqlDataAdapter();
                // adapter.InsertCommand =new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@userId",this.UserId);
                cmd.Parameters.AddWithValue("@userName",users.UserName);
                cmd.Parameters.AddWithValue("@password", users.Password);
                cmd.Parameters.AddWithValue("@mobileNumber",users.MobileNumber);
                cmd.Parameters.AddWithValue("@userrole", users.Role);

                  int rows = cmd.ExecuteNonQuery();
                 //  rowsup++;
                   if (rows>0)
                      {
                        isSucceed =true;
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

        public bool SelectUser(User users)
        {
            bool correct = false;
            
            SqlConnection conn = db.ConnectDB();
           
            try
            {  
                string sql = "SELECT id, password FROM tbl_USER WHERE id =@userid and password =@password";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@userid", users.userId);
                cmd.Parameters.AddWithValue("@password", users.Password);
                
                SqlDataReader myReader = cmd.ExecuteReader();

                if(myReader.Read())
                {
                   
                    correct = true;
                }
                else
                {
                    correct = false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { conn.Close(); }
            return correct;

        }


    }
}
