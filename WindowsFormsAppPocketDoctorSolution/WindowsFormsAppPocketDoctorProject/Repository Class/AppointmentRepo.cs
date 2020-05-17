using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class AppointmentRepo
    {
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        DataTable dataTable;
        FormLogin flog = new FormLogin();
        DoctorRepo drepo = new DoctorRepo();
        float totalSalary = 0;



        internal DataTable GetSalary()
        {
            string drid = FormAppointment.docid;
            try
            {
                string sql = "SELECT earnings from tbl_Doctor where dr_id ='"+drid+"' ";

                dataTable = dbCon.GetDataTable(sql);


            }
            catch (Exception ex) { }




            return dataTable;
        }
        internal bool InsertRow(Appointment dp)
        {
            string drid = FormAppointment.docid;
            DataTable dt = this.GetSalary();

            totalSalary = float.Parse(dt.Rows[0]["earnings"].ToString())+ DoctorRepo.salary;
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Appointment (dr_id, p_id, visiting_date ) VALUES( '"+dp.dr_id+"', '"+dp.p_id+"', '"+dp.visiting_date+"')";


                string sl = "Update tbl_Doctor set earnings = " + totalSalary + " where dr_id = '" + drid + "' ";

                var row = dbCon.ExecuteUpdateQuery(sql);
                var row1 = dbCon.ExecuteUpdateQuery(sl);
                if (row == 1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex+" "); }
            finally { dbCon.CloseConnection(); }


            return succeed;
        }

          
        internal DataTable SearchAppointment(string name, string category, DateTime date)
        {
            
            try
            {
                string sql = "Select userid from tbl_User join tbl_Doctor d on username like '%" + name + "%' and d.dr_catagory like '%" + category + "%' and d.dr_id = userid";
                DataTable dt = dbCon.GetDataTable(sql);
                string id = dt.Rows[0]["userid"].ToString();

                string query = "Select a.appt_id, p.p_id, p.name, p.mobilenumber,a.visiting_date from tbl_Appointment a join tbl_Patient p on a.p_id =p.p_id and a.dr_id ='" + id + "' and a.visiting_date = '"+date+"'";
                dataTable = dbCon.GetDataTable(query);
             
            }
            catch (Exception ex) { }
            finally { dbCon.CloseConnection(); }

             return dataTable;
        }
          internal DataTable GetAppointment()
        {
            try
            {
                string sql = "SELECT a.appt_id, p.p_id,p.name,p.mobilenumber,a.visiting_date FROM tbl_Appointment a join tbl_Patient p on a.p_id= p.p_id";
               
                dataTable = dbCon.GetDataTable(sql);
                

            }
            catch (Exception ex) { }




            return dataTable;
        }
        internal DataTable SearchAppointedPatient(string keyWord)
        {
            string drid = FormLogin.uid;
            try
            {

                string sql = "SELECT p.p_id, p.name, p.age, p.gender, a.visiting_date FROM tbl_Appointment a join tbl_Patient p on p.p_id LIKE '%"+keyWord+ "%' and a.dr_id= '" + drid + "' and p.p_id = a.p_id OR p.mobilenumber LIKE '%" + keyWord + "%' and a.dr_id= '" + drid + "' and p.p_id = a.p_id OR p.name LIKE '%" + keyWord + "%' and a.dr_id= '" + drid + "' and p.p_id = a.p_id ";
                dataTable = dbCon.GetDataTable(sql);


            }
            catch (Exception ex) { }




            return dataTable;
        }
        internal DataTable GetAppointtedPatient(DateTime dateT)
        {
            string drid = FormLogin.uid;
            try
            {
                string sql = @"SELECT p.p_id, p.name, p.age, p.gender, a.visiting_date from tbl_Appointment a,
                              tbl_Patient p where a.dr_id = '" + drid + "' and p.p_id = a.p_id and a.visiting_date ='"+dateT+"' ";

                dataTable = dbCon.GetDataTable(sql);

    

            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
 

            return dataTable;

        }
        internal bool DeleteAppointment(Appointment a)
        {
            string drid = FormAppointment.docid;
            DataTable dt = this.GetSalary();
            totalSalary = float.Parse(dt.Rows[0]["earnings"].ToString()) - DoctorRepo.salary;
            bool succeed = false;
            try
            {
                string sql = "DELETE FROM tbl_Appointment WHERE appt_id = '" + a.appt_id + "'";
                string sl = "Update tbl_Doctor set earnings = " + totalSalary + " where dr_id = '" + drid + "' ";

                var row = dbCon.ExecuteUpdateQuery(sql);
                var row1 = dbCon.ExecuteUpdateQuery(sl);
                if (row == 1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }



            return succeed;
        }
    }
}
