using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class PatientHistoryRepo
    {
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        DataTable dataTable;
        float totalSalary = 0;

        internal bool InsertTestReport(string pid, string filePDF, MemoryStream ms)
        {
            bool succeed = false;

            try
            {
                var dt = dbCon.Query("Update tbl_Report set report = @filepdf, rep_name = '" + filePDF + "' where p_id = '"+pid+"'");

                dt.Parameters.AddWithValue("@filepdf", SqlDbType.VarBinary).Value = ms.ToArray();

                var row = dt.ExecuteNonQuery();
                if (row > 0)
                {
                    succeed = true;

                }
                else
                {
                    succeed = false;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }
            return succeed;
        }
        internal DataTable GetSalary(string drid)
        {
        
            try
            {
                string sql = "SELECT earnings from tbl_Doctor where dr_id ='" + drid + "' ";

                dataTable = dbCon.GetDataTable(sql);


            }
            catch (Exception ex) { }




            return dataTable;
        }
        internal bool InsertPrescription(string pid,string filePDF, MemoryStream ms, string drid)
        {
           
            DataTable daTa = this.GetSalary(drid);
            totalSalary = float.Parse(daTa.Rows[0]["earnings"].ToString()) + DoctorRepo.salary;
            bool succeed = false;

            try
            {
                var dt = dbCon.Query("insert into tbl_PatientHistory (prescription,p_id, p_filename) values (@filepdf, '" + pid + "', '" + filePDF + "')");
                dt.Parameters.AddWithValue("@filepdf", SqlDbType.VarBinary).Value = ms.ToArray();
               
                string sl = "Update tbl_Doctor set earnings = " + totalSalary + " where dr_id = '" + drid + "' ";
                var row1 = dbCon.ExecuteUpdateQuery(sl);

                var row = dt.ExecuteNonQuery();
                if (row > 0 && row1>0)
                {
                    succeed = true;
                    
                }
                else
                {
                    succeed = false;
                 

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }
            return succeed;
        }

        internal DataTable GetPrescription(string filename)
        {
            try
            {
                string query = "Select prescription from tbl_PatientHistory where p_filename ='"+filename+"' ";
                dataTable = dbCon.GetDataTable(query);

               /* @"SELECT p.p_id, p.name, p.age, p.gender, a.visiting_date, h.p_fileame from tbl_Appointment a,
                              tbl_Patient p, tbl_PatientHistory h
                              where a.dr_id = '" + drid + "' and p.p_id = a.p_id  or p.p_id = h.p_id";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return dataTable;

        }

        internal DataTable GetPatientHistory()
        {
            string drid = FormLogin.uid;
            try
            {
                string query = @"SELECT p.p_id, p.name, a.visiting_date, h.p_filename from tbl_Appointment a,
                               tbl_Patient p, tbl_PatientHistory h
                               where a.dr_id = '" + drid + "' and p.p_id = a.p_id and p.p_id = h.p_id or h.p_filename=null order by a.visiting_date DESC"; 
                
                dataTable = dbCon.GetDataTable(query);

           
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return dataTable;

        }
        internal DataTable SearchPrescriptionHistory(string keyword)
        {
            string drid = FormLogin.uid;
            try
            {
                string sql = @"SELECT p.p_id, p.name, a.visiting_date, h.p_filename from tbl_Appointment a,
                              tbl_Patient p, tbl_PatientHistory h where p.name Like '%"+keyword+"%' and a.dr_id = '" + drid + "' and p.p_id = a.p_id and " +
                              "p.p_id = h.p_id or h.p_filename = null order by a.visiting_date DESC";
                dataTable = dbCon.GetDataTable(sql);
             
        

            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
            return dataTable;
        }
    }
}
