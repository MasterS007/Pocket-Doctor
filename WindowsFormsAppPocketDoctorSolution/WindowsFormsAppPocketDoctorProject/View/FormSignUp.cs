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
    public partial class FormSignUp : Form
    {
        User users = new User();
        UserRepo urepo = new UserRepo();
        DoctorRepo docrepo = new DoctorRepo();
     
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void LoadAutoUserId()
        {
            int serial = urepo.AutoIDValue();
            urepo.UserId = (++serial).ToString("d4");
            users.UserId = urepo.UserId;
            
        }

        /*private void ChkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }*/
       // string Id;
        
        private void BtnSingUp_Click(object sender, EventArgs e)
        {
           // users.UserId = uId;
            User userDoc = new Doctor(txtUserName.Text, txtPassword.Text, txtMobileNum.Text);
            User userReceptionist = new Receptionist (txtUserName.Text, txtPassword.Text, txtMobileNum.Text);
            User userPathologist = new Pathologist(txtUserName.Text, txtPassword.Text, txtMobileNum.Text);
           
            if (this.cmbUserType.Text == "Doctor")
            {
                
                string docCategory = this.cmbCategory.Text;
                
                 bool success= urepo.InsertUser(userDoc,users.UserId+"-D");
                bool sucs = docrepo.InsertDoctorCategory(users.UserId + "-D", docCategory);
                  if (success == false)
                  {
                     MessageBox.Show("Failed to insert");

                  }
                 else
                  {
                    // MessageBox.Show("Successful Signup");
                    this.Visible = false;
                    FormLogin fm = new FormLogin();
                    fm.Show();
                  }

            }

           else if (this.cmbUserType.Text == "Receptionist")
            {
                bool success = urepo.InsertUser(userReceptionist,users.UserId+"-R");

                if (success == false)
                {
                    MessageBox.Show("Failed to insert");

                }
                else
                {
                    // MessageBox.Show("Successful Signup");
                    this.Visible = false;
                    FormLogin fm = new FormLogin();
                    fm.Show();
                }

            }
            else if (this.cmbUserType.Text == "Pathologist")
            {
                bool success = urepo.InsertUser(userPathologist,users.UserId+"-P");

                if (success == false)
                {
                    MessageBox.Show("Failed to insert");

                }
                else
                {
                    // MessageBox.Show("Successful Signup");
                    this.Visible = false;
                    FormLogin fm = new FormLogin();
                    fm.Show();
                }

            }

        }

        private void FormSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            this.lblDoctorCategory.Hide();
            this.cmbCategory.Hide();
             this.LoadAutoUserId();
            //users.UserId = uId;
           
            //
           // Id = uId + "-D";
          // MessageBox.Show(users.UserId+"-D");

        }

        private void CmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblDoctorCategory.Show();
            this.cmbCategory.Show();
        }
    }
}
