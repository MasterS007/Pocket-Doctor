using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Repository_Class;
using System.Data.SqlClient;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class UserControlProfile : UserControl
    {
        Doctor doc = new Doctor();
        DoctorRepo docRepo = new DoctorRepo();
        public UserControlProfile()
        {
            InitializeComponent();
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            DataTable dt = docRepo.GetDoctorInfo();



            this.lblName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            this.lblUserId.Text = dt.Rows[dt.Rows.Count - 1]["userid"].ToString();
            this.lblEduBackgrnd.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            this.textPassword.Text = dt.Rows[dt.Rows.Count - 1]["password"].ToString();
            this.lblMobile.Text = dt.Rows[dt.Rows.Count - 1]["mobilenumber"].ToString();
        }
    }
}
