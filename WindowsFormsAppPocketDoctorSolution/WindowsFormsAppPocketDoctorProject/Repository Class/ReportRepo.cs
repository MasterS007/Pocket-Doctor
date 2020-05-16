using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class ReportRepo
    {
        DataTable dataTable;
        
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        

        internal bool InsertTest(string pid, List<string> checkedItems)
          {
            
            bool succeed = false;

            try
            {
                int tid;
                int row = 0;

                foreach (string s in checkedItems)
                {
                    string quyery = "Select t_id from tbl_Test where name = '" + s + "'";
                    dataTable = dbCon.GetDataTable(quyery);
                    tid = Convert.ToInt32(dataTable.Rows[0]["t_id"].ToString());

                    string sql = "INSERT INTO tbl_Report (t_id, p_id) VALUES(  ' " +tid+ " ', '" + pid + "')";
                    row = dbCon.ExecuteUpdateQuery(sql);
                   
                }
                if (row > 0)
                {
                    succeed = true;
                }
                else
                {
                    succeed = false;
                }



            }

            catch (Exception ex) { MessageBox.Show(ex + ""); }

            return succeed;


          }







    }
}
