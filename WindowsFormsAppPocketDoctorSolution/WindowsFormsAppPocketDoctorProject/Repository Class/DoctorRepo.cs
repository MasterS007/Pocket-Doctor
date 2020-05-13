using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class DoctorRepo
    {
        DataTable dataTable;
        Doctor doc = new Doctor();
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        public const float salary = 800;
        
        
        internal DataTable GetDoctorInfo()
        {

            string d = FormLogin.uid;

            
            try
            {
                string sql = "SELECT userid, username,password,mobilenumber,edu_background , earnings, dr_catagory from tbl_User  join tbl_Doctor  on userid = '"+d+"' AND dr_id ='"+d+"'";

                dataTable = dbCon.GetDataTable(sql);

            }
            catch (Exception ex) { MessageBox.Show(ex+""); }

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
            catch (Exception ex) { MessageBox.Show(ex+""); }

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

        internal DataTable GetDailySalary( )
        {
            FormDoctor fdoc = new FormDoctor();
            DateTime daTe = Convert.ToDateTime(fdoc.daTe);
            string d = FormLogin.uid;
            try
            {
                string sql = "Select Count(appt_id) salary from tbl_Appointment where dr_id='" + d + "' and visiting_date = '"+daTe+"' ";
                dataTable = dbCon.GetDataTable(sql);
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
            finally { dbCon.CloseConnection(); }


            return dataTable;

        }
        internal DataTable GetMonthlySalary(DateTime from, DateTime to)
        {
            string d = FormLogin.uid;
            try
            {
                string sql = "Select Count(appt_id) salary from tbl_Appointment where dr_id='" + d + "' and visiting_date Between '"+from+"' and '"+to+"' ";
                dataTable = dbCon.GetDataTable(sql);
            }
            catch(Exception ex) { MessageBox.Show(""+ex); }
            finally { dbCon.CloseConnection(); }


            return dataTable;
        }
        internal bool UpdateDoctor(User d, Doctor doc)
        {
            string u = FormLogin.uid;

            bool succeed = false;
            try
            {
                string sql = @"UPDATE tbl_User SET username = '" + d.username + "', password = '"+d.password+"', mobilenumber='"+d.mobilenumber+"' WHERE  userid = '" +u  +"'";

                string sq = "UPDATE tbl_Doctor SET edu_background = '" + doc.educational_background+"' WHERE dr_id = '"+u+"'";
                var row = dbCon.ExecuteUpdateQuery(sql);
                var row2 = dbCon.ExecuteUpdateQuery(sq);
                if (row == 1 || row2 ==1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex+""); }



            return succeed;
        }

    }
}
