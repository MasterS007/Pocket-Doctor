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
        //DoctorPatient docp = new DoctorPatient();
        DatabaseConnection DB { get; set; }
        internal bool InsertRow(Appointment dp)
        {
            this.DB = new DatabaseConnection();
            bool succeed = false;
            try
            {
                string sql = "INSERT INTO tbl_Appointment (dr_id, p_id, visiting_date ) VALUES( @drid, @pid, @visitingdate)";
                var cmd = DB.Query(sql);

                //.Show(dp.dr_id + " "+dp.p_id + " "+ dp.visiting_date);
                //  cmd.Parameters.AddWithValue("PId", p.PId);
                cmd.Parameters.AddWithValue("@drid", dp.dr_id);
                cmd.Parameters.AddWithValue("@pid", dp.p_id);
                cmd.Parameters.AddWithValue("@visitingdate", dp.visiting_date);
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
            catch (Exception ex) { MessageBox.Show(ex+" "); }

            finally { this.DB.CloseConnection(); }

            return succeed;
        }
    }
}
