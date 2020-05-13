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
       
        DoctorRepo docRepo = new DoctorRepo();
        

        public UserControlProfile()
        {
            InitializeComponent();
            this.ShowSalary();
        }
        

        private void UserControlProfile_Load(object sender, EventArgs e)
        {

            DataTable dt = docRepo.GetDoctorInfo(); 
            this.lblName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            this.lblUserId.Text = dt.Rows[dt.Rows.Count - 1]["userid"].ToString();
            this.lblEduBackgrnd.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            this.textPassword.Text = dt.Rows[dt.Rows.Count - 1]["password"].ToString();
            this.lblMobile.Text = dt.Rows[dt.Rows.Count - 1]["mobilenumber"].ToString();
            this.lblEarning.Text = dt.Rows[dt.Rows.Count - 1]["earnings"].ToString();

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FormEditProfile fe = new FormEditProfile();
            fe.Visible = true;
        }

         internal void ShowSalary()
        {
            if(this.cmbEarnings.Text == "Yearly")
            {
                this.lblFrom.Show();
                this.lblTo.Show();
                this.dateTimeFrom.Show();
                this.dateTimeTo.Show();

               
            }
            else if(this.cmbEarnings.Text=="Daily")
            {
                this.lblFrom.Hide();
                this.lblTo.Hide();
                this.dateTimeFrom.Hide();
                this.dateTimeTo.Hide();
            }

           else if (this.cmbEarnings.Text == "Monthly")
            {
                this.lblFrom.Show();
                this.lblTo.Show();
                this.dateTimeFrom.Show();
                this.dateTimeTo.Show();
            }

        }

        private void CmbEarnings_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ShowSalary();
        }

        private void BtnShowSalary_Click(object sender, EventArgs e)
        {
            if(this.cmbEarnings.Text== "Monthly" || this.cmbEarnings.Text == "Yearly")
            {
                DataTable dt = docRepo.GetMonthlySalary(Convert.ToDateTime(this.dateTimeFrom.Text), Convert.ToDateTime(this.dateTimeTo.Text));

                float mSalary = float.Parse(dt.Rows[0]["salary"].ToString()) *DoctorRepo.salary ;
                this.lblEarning.Text = mSalary.ToString();
            }

             else if (this.cmbEarnings.Text == "Daily")
            {
                DataTable dt = docRepo.GetDailySalary();

                float mSalary = float.Parse(dt.Rows[0]["salary"].ToString()) *DoctorRepo.salary;
                this.lblEarning.Text = mSalary.ToString();
            }

        }
    }
}
