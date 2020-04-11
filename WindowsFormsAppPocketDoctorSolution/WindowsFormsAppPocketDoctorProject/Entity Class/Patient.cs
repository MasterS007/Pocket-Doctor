using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.Entity_Class
{
    class Patient
    {
        private int pid;
        DatabaseConnection DB { get; set; }
        DataTable dataTable;


        internal Patient() { }
        internal Patient(string name, int age, string mobilenumber)
        {   
            this.Name = name;
            this.Age = age;
            this.MobileNumber = mobilenumber;
        }

        internal string Gender
        { get; set; }

        internal string Name
        { get; set; }
        internal int Age
        { get; set; }
        internal string MobileNumber
        { get; set; }

        internal int PId
        { set; get; }


        internal bool InsertPatient(Patient p)
        {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Patient (name,age,gender,mobilenumber) VALUES( @Name, @Age, @Gender, @MobileNumber)";
                var cmd = DB.Query(sql);

                //  cmd.Parameters.AddWithValue("PId", p.PId);
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Gender", p.Gender);
                cmd.Parameters.AddWithValue("@Age", p.Age);
                cmd.Parameters.AddWithValue("@MobileNumber", p.MobileNumber);
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
               dataTable= DB.ExecuteQuery(sql);
                //db.Sda.Fill(dataTable);

            }
            catch(Exception ex) { }

            finally { DB.CloseConnection(); }
          

            return dataTable;
        }

        internal DataTable SearchPatient(string keyWord)
        {
            this.DB = new DatabaseConnection();

            try
            {
                string sql = "SELECT * FROM tbl_Patient WHERE mobilenumber LIKE '%"+keyWord+ "%' OR name LIKE '%" + keyWord + "%'";
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

          internal bool UpdatePatient(Patient p)
          {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
               string sql = @"UPDATE tbl_Patient SET  name= @Name ,
                            gender= @Gender, age = @Age, mobilenumber= @MobileNumber 
                            WHERE pid = @PId";

                var cmd = DB.Query(sql);
                
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Gender", p.Gender);
                cmd.Parameters.AddWithValue("@Age", p.Age);
                cmd.Parameters.AddWithValue("@MobileNumber", p.MobileNumber);
                cmd.Parameters.AddWithValue("PId", p.PId);
                int row = cmd.ExecuteNonQuery();

                if (row==1)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }
            }
            catch(Exception ex) { }

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
                
                cmd.Parameters.AddWithValue("PId", p.PId);
                int row =cmd.ExecuteNonQuery();
                if (row==1)
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
