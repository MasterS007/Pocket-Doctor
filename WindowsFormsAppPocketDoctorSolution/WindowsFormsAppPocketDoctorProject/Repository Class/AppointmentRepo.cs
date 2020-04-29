using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;

namespace WindowsFormsAppPocketDoctorProject.Repository_Class
{
    class AppointmentRepo
    {
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();

        internal bool InsertRow(Appointment dp)
        {
            
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Appointment (dr_id, p_id, visiting_date ) VALUES( '"+dp.dr_id+"', '"+dp.p_id+"', '"+dp.visiting_date+"')";
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
            catch (Exception ex) { MessageBox.Show(ex+" "); }
            finally { dbCon.CloseConnection(); }


            return succeed;
        }
    }
}
