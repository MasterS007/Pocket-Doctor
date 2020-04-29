using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class UserRepo
    {
        internal User userr= new User();
        private string userid;

        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        
       

        public int AutoIDValue()
        {
            int number;
               var dt = dbCon.GetDataTable("select * from tbl_User;");
            if (dt.Rows.Count == 0) { number = 0;
                return number;
            }
            
                string value = dt.Rows[dt.Rows.Count - 1]["userid"].ToString();

                string[] id = value.Split('-');
                 number = Convert.ToInt32(id[1]);
                return number;
          
        }
        
        
        internal virtual string UserId
        {
            get { return this.userid; }
            set
            {
                this.userid = "U-" + value;

                
            }
        }
        
        public bool InsertUser(User users, string keyword)
        {
            bool isSucceed = false;

            try
            {
                string sql = "INSERT INTO tbl_User ( userid, username, password, mobilenumber) VALUES ( '"+keyword+"','"+users.username+"' , '"+users.password+"','"+users.mobilenumber+"')";
               
                var row = dbCon.ExecuteUpdateQuery(sql);
                if (row==1)
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
                MessageBox.Show(ex+"");
            }

            finally {dbCon.CloseConnection(); }
            return isSucceed;
        }

        public string SelectUser(User users)
        {
            string role=null;
            bool correct = false;
            

            try
            {    string sql = "SELECT userid, password FROM tbl_USER WHERE userid ='"+ users.UserId +"' and password ='"+ users.password +"'";

                var queryResut = dbCon.Query(sql);
                var dt = dbCon.GetDataTable(sql);
                string value = dt.Rows[dt.Rows.Count - 1]["userid"].ToString();
                string[] id = value.Split('-');
                
                SqlDataReader myReader = queryResut.ExecuteReader();
                

                if (myReader.Read()==true)
                {
                    role = id[2];

                }
                else
                {
                    role = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
            }
            finally { dbCon.CloseConnection(); }
            return role;

        }

    }
}
