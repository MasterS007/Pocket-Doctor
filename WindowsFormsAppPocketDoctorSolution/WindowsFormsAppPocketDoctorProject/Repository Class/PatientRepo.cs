using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class PatientRepo
    {
        DataTable dataTable;
        Patient p = new Patient();
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        private string p_id;
        public int AutoIDValue()
        {
            int number;
            var dt = dbCon.GetDataTable("select * from tbl_Patient;");
            if (dt.Rows.Count == 0)
            {
                number = 0;
                return number;
            }

            string value = dt.Rows[dt.Rows.Count - 1]["p_id"].ToString();

            string[] id = value.Split('-');
            number = Convert.ToInt32(id[1]);
            return number;

        }

        internal virtual string P_Id
        {
            get { return this.p_id; }
            set
            {
                this.p_id = "P-" + value;


            }
        }
        internal bool InsertPatient(Patient p, string keyword)
        {
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Patient (p_id, name,age,gender,mobilenumber,bloodgroup) VALUES( '"+keyword+"', '"+p.name+"', '"+p.age+"', '"+p.gender+"', '"+p.mobilenumber+"','"+p.bloodgroup+"')";
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
                    " mobilenumber='"+p.mobilenumber+"', bloodgroup = '"+p.bloodgroup+"' WHERE p_id = '"+p.p_id+"'";

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
            catch (Exception ex) { MessageBox.Show(""+ex); }

           

            return succeed;
        }

        internal bool DeletePatient(Patient p)
        {
            bool succeed = false;
            try
            {
                string sql = "DELETE FROM tbl_Patient WHERE p_id = '"+p.p_id+"'";
                string sql1 = "DELETE FROM tbl_PatientHistory Where p_id = '" + p.p_id + "'";
               string sql2 = "DELETE FROM tbl_Appointment Where p_id = '" + p.p_id + "'";
                string sql3 = "DELETE FROM tbl_Report WHere p_id ='" + p.p_id + "'";
                
                var row1 = dbCon.ExecuteUpdateQuery(sql1);
                var row2 = dbCon.ExecuteUpdateQuery(sql2);
                var row3 = dbCon.ExecuteUpdateQuery(sql3);
                var row = dbCon.ExecuteUpdateQuery(sql);

                if (row>0 && row1 >0 || row3>0 )
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(""+ex); }

            

            return succeed;
        }

    }
}
