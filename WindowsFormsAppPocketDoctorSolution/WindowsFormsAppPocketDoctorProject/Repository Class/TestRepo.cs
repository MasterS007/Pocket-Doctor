using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class TestRepo
    {
        DataTable dataTable;  
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        internal DataTable GetTest()
        {
            try
            {
                string sql = "select name from tbl_Test";
                // SqlCommand cmd = db.Query(sql);
                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //adapter.Fill(dataTable);
                dataTable = dbCon.GetDataTable(sql);
                //db.Sda.Fill(dataTable);

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

            finally { dbCon.CloseConnection(); }

            return dataTable;
        }
    }
}
