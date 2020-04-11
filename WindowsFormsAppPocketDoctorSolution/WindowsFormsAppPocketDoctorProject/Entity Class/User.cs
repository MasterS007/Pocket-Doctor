using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class

{
     internal class User
    {
        
        internal int id { get; set; }
        internal string name { get; set; }
        internal string password { get; set; }
        internal string mobilenumber { get; set; }
        internal string role { get; set; }
        // private static ushort serialNo = 1;

        



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
            this.name = userName;
            this.password = password;
            this.mobilenumber = mobileNumber;
            this.role = role;
        }
       

       
     
       

         

    }
}
