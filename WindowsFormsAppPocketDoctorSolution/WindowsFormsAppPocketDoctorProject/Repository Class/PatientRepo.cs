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
    class PatientRepo
    {
        DataTable dataTable;
        Patient p = new Patient();
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        internal bool InsertPatient(Patient p)
        {
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Patient (name,age,gender,mobilenumber,bloodgroup) VALUES( '"+p.name+"', '"+p.age+"', '"+p.gender+"', '"+p.mobilenumber+"','"+p.bloodgroup+"')";
                var row = dbCon.ExecuteUpdateQuery(sql);
            
                if (row == 1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { }

           

            return succeed;
        }
        internal DataTable GetPatient()
        {
            try
            {
                string sql = "SELECT * FROM tbl_Patient";
                //SqlCommand cmd = db.Query(sql);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //adapter.Fill(dataTable);
                dataTable = dbCon.GetDataTable(sql);
                //db.Sda.Fill(dataTable);

            }
            catch (Exception ex) { }

           


            return dataTable;
        }

        internal DataTable SearchPatient(string keyWord)
        {
            try
            {
                string sql = "SELECT * FROM tbl_Patient WHERE mobilenumber LIKE '%" + keyWord + "%' OR name LIKE '%" + keyWord + "%'";
                dataTable = dbCon.GetDataTable(sql);
               

            }
            catch (Exception ex) { }

            


            return dataTable;
        }

        internal bool UpdatePatient(Patient p)
        {
            bool succeed = false;
            try
            {
              string sql = @"UPDATE tbl_Patient SET name = '"+ p.name + "', gender= '" + p.gender +"', age = '"+p.age+"'," +
                    " mobilenumber='"+p.mobilenumber+"', bloodgroup = '"+p.bloodgroup+"' WHERE pid = '"+p.pid+"'";

                var row = dbCon.ExecuteUpdateQuery(sql);
                if (row == 1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { }

           

            return succeed;
        }

        internal bool DeletePatient(Patient p)
        {
            bool succeed = false;
            try
            {
                string sql = "DELETE FROM tbl_Patient WHERE pid = '"+p.pid+"'";
                var row = dbCon.ExecuteUpdateQuery(sql);
                if (row == 1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { }

            

            return succeed;
        }

    }
}
