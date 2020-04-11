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
        DatabaseConnection DB { get; set; }
        DataTable dataTable;
        Patient p = new Patient();

        internal bool InsertPatient(Patient p)
        {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Patient (name,age,gender,mobilenumber,bloodgroup) VALUES( @Name, @Age, @Gender, @MobileNumber,@Bloodgroup)";
                var cmd = DB.Query(sql);

                //  cmd.Parameters.AddWithValue("PId", p.PId);
                cmd.Parameters.AddWithValue("@Name", p.name);
                cmd.Parameters.AddWithValue("@Gender", p.gender);
                cmd.Parameters.AddWithValue("@Age", p.age);
                cmd.Parameters.AddWithValue("@MobileNumber", p.mobilenumber);
                cmd.Parameters.AddWithValue("@Bloodgroup", p.bloodgroup);
                int row = cmd.ExecuteNonQuery();
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

            finally { this.DB.CloseConnection(); }

            return succeed;
        }
        internal DataTable GetPatient()
        {
            this.DB = new DatabaseConnection();
            //DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Patient";
                //SqlCommand cmd = db.Query(sql);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //adapter.Fill(dataTable);
                dataTable = DB.ExecuteQuery(sql);
                //db.Sda.Fill(dataTable);

            }
            catch (Exception ex) { }

            finally { DB.CloseConnection(); }


            return dataTable;
        }

        internal DataTable SearchPatient(string keyWord)
        {
            this.DB = new DatabaseConnection();

            try
            {
                string sql = "SELECT * FROM tbl_Patient WHERE mobilenumber LIKE '%" + keyWord + "%' OR name LIKE '%" + keyWord + "%'";
                dataTable = DB.ExecuteQuery(sql);
               

            }
            catch (Exception ex) { }

            finally { DB.CloseConnection(); }


            return dataTable;
        }

        internal bool UpdatePatient(Patient p)
        {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
                string sql = @"UPDATE tbl_Patient SET  name= @Name ,
                            gender= @Gender, age = @Age, mobilenumber= @MobileNumber , bloodgroup =@Bloodgroup
                            WHERE pid = @PId";

                var cmd = DB.Query(sql);

                cmd.Parameters.AddWithValue("@Name", p.name);
                cmd.Parameters.AddWithValue("@Gender", p.gender);
                cmd.Parameters.AddWithValue("@Age", p.age);
                cmd.Parameters.AddWithValue("@MobileNumber", p.mobilenumber);
                cmd.Parameters.AddWithValue("PId", p.pid);
                cmd.Parameters.AddWithValue("@Bloodgroup", p.bloodgroup);

                int row = cmd.ExecuteNonQuery();

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

            finally { this.DB.CloseConnection(); }

            return succeed;
        }

        internal bool DeletePatient(Patient p)
        {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
                string sql = "DELETE FROM tbl_Patient WHERE pid = @PId";
                var cmd = DB.Query(sql);

                cmd.Parameters.AddWithValue("PId", p.pid);
                int row = cmd.ExecuteNonQuery();
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

            finally { this.DB.CloseConnection(); }

            return succeed;
        }

    }
}
