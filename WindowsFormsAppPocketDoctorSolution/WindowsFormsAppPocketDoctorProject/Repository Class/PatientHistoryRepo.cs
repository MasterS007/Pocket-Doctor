﻿using System;
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
        internal bool InsertPrescription(string pid,string filePDF, MemoryStream ms)
        {
            bool succeed = false;

            try
            {
                var dt = dbCon.Query("insert into tbl_PatientHistory (prescription,p_id, p_filename) values (@filepdf, '" + pid + "', '" + filePDF + "')");

                dt.Parameters.AddWithValue("@filepdf", SqlDbType.VarBinary).Value = ms.ToArray();

                var row = dt.ExecuteNonQuery();
                if (row > 0)
                {
                    succeed = true;
                    MessageBox.Show("Inserted");
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
                               where a.dr_id = '" + drid + "' and p.p_id = a.p_id and p.p_id = h.p_id or h.p_filename=null"; 
                
                dataTable = dbCon.GetDataTable(query);

           
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.ToString());
            }
            return dataTable;

        }
        internal DataTable GetPrescriptionHistory()
        {
            return dataTable;
        }
    }
}