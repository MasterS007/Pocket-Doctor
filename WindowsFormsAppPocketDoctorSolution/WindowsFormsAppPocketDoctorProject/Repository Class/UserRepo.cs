using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class UserRepo
    {
        User users = new User();
        DatabaseConnection DB { get; set; }
        public bool InsertUser(User users)
        {
            this.DB = new DatabaseConnection();
            // SqlConnection conn = db.ConnectDB();
            bool isSucceed = false;

            try
            {
                string sql = "INSERT INTO tbl_User ( name, password, mobilenumber,userrole) VALUES ( @userName , @password, @mobileNumber, @userrole)";
                var cmd = this.DB.Query(sql);



                //cmd.Parameters.AddWithValue("@userId",this.UserId);
                cmd.Parameters.AddWithValue("@userName", users.name);
                cmd.Parameters.AddWithValue("@password", users.password);
                cmd.Parameters.AddWithValue("@mobileNumber", users.mobilenumber);
                cmd.Parameters.AddWithValue("@userrole", users.role);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
            finally { this.DB.CloseConnection(); }

            return isSucceed;
        }

        public bool SelectUser(User users)
        {
            bool correct = false;

            this.DB = new DatabaseConnection();

            try
            {
                string sql = "SELECT id, password FROM tbl_USER WHERE id =@userid and password =@password";
                var queryResut = this.DB.Query(sql);
                queryResut.Parameters.AddWithValue("@userid", users.id);
                queryResut.Parameters.AddWithValue("@password", users.password);

                SqlDataReader myReader = queryResut.ExecuteReader();

                if (myReader.Read())
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
            finally { this.DB.CloseConnection(); }
            return correct;

        }

    }
}
