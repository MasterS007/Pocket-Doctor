using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class DoctorRepo
    {
        DatabaseConnection DB { get; set; }
        DataTable dataTable;
        Doctor doc = new Doctor();        
        internal DataTable GetDoctor()
        {
            this.DB = new DatabaseConnection();
            //DataTable dataTable = new DataTable();

            try
            {
                string sql = "select id, name , dr_catagory from tbl_User  join tbl_DoctorInfo  on id = dr_id ";
               // SqlCommand cmd = db.Query(sql);
               //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //adapter.Fill(dataTable);
                dataTable = DB.ExecuteQuery(sql);
                //db.Sda.Fill(dataTable);

            }
            catch (Exception ex) { }

            finally { DB.CloseConnection(); }


            return dataTable;
        }

        internal DataTable SearchDoctor(string keyWord)
        {
            this.DB = new DatabaseConnection();

            try
            {
                string sql = "SELECT u.id, u.name, d.dr_catagory FROM tbl_User u join tbl_DoctorInfo d on d.dr_catagory LIKE '%"+keyWord+ "%' AND u.id=d.dr_id or u.name LIKE '"% + keyWord + "%' AND u.id=d.dr_id";
                dataTable = DB.ExecuteQuery(sql);


            }
            catch (Exception ex) { }

            finally { DB.CloseConnection(); }


            return dataTable;
        }
    }
}
