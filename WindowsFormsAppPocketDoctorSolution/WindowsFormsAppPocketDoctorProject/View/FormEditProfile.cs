using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormEditProfile : Form
    {
        DoctorRepo drepo = new DoctorRepo();
        User users = new User();
        Doctor doc = new Doctor();
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            DataTable dt = drepo.GetDoctorInfo();
            this.txtName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            this.txtEdubackground.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            this.txtPassword.Text = dt.Rows[dt.Rows.Count - 1]["password"].ToString();
            this.txtMobile.Text = dt.Rows[dt.Rows.Count - 1]["mobilenumber"].ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            users.username = this.txtName.Text;
            users.password = this.txtPassword.Text;
            users.mobilenumber = this.txtMobile.Text;
            doc.educational_background = this.txtEdubackground.Text;

            if (MessageBox.Show("Do you want to update?", "Row Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool succeed = drepo.UpdateDoctor(users, doc);


                if (succeed == true)
                {
                    MessageBox.Show("Saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("not saved. Error Occured");
                }
            }
            else
            {
                MessageBox.Show(" is not saved", "Row Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

            
    }
}
