using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPocketDoctorProject.Classes
{
    class Patient
    {
        private int pid;

        DatabaseConnection db = new DatabaseConnection();

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

        internal DataTable ShowPatient()
        {
            SqlConnection conn = db.ConnectDB();
            DataTable dataTable = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Patient";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);


            }
            catch(Exception ex) { }

            finally { conn.Close(); }
          

            return dataTable;
        }


    }
}
