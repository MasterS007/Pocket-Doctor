using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class DoctorRepo
    {
        DataTable dataTable;
        Doctor doc = new Doctor();
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();

        internal DataTable GetDoctorInfo()
        {
            
            try
            {
                string sql = "SELECT userid, username,password,mobilenumber,edu_background from tbl_User  join tbl_Doctor  on userid = 'U-0001-D' AND dr_id ='U-0001-D'";

                dataTable = dbCon.GetDataTable(sql);

            }
            catch (Exception ex) { }

            finally { dbCon.CloseConnection(); }

                return dataTable;
          
        }
        internal DataTable GetDoctor()
        {
            
            //DataTable dataTable = new DataTable();

            try
            {
                string sql = "select userid, username , dr_catagory from tbl_User  join tbl_Doctor  on userid = dr_id ";
               // SqlCommand cmd = db.Query(sql);
               //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //adapter.Fill(dataTable);
                dataTable =dbCon.GetDataTable(sql);
                //db.Sda.Fill(dataTable);

            }
            catch (Exception ex) { }

            finally { dbCon.CloseConnection(); }

            return dataTable;
        }

        internal DataTable SearchDoctor(string keyWord)
        {
            try
            {
                string sql = "SELECT u.userid, u.username, d.dr_catagory FROM tbl_User u join tbl_Doctor d on d.dr_catagory LIKE '%" + keyWord + "%' AND u.userid=d.dr_id or u.username LIKE '%" + keyWord + "%' AND u.userid=d.dr_id";
                dataTable = dbCon.GetDataTable(sql);
            }

            catch (Exception ex) { }
            finally { dbCon.CloseConnection(); }

          
            return dataTable;

        }
    }
}
