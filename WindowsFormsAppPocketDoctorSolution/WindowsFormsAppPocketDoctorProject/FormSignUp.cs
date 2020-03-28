using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormSignUp : Form
    {
        private User userDoc = new Doctor();
        private DatabaseConnection db = new DatabaseConnection();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void ChkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

       

        private void BtnSingUp_Click(object sender, EventArgs e)
        {
            db.UserId = userDoc.UserId;
            db.UserName = txtUserName.Text;
            db.Password = txtPassword.Text;
            db.MobileNumber = txtMobileNum.Text;

            if (this.cmbUserType.Text == "Doctor")
            {
                
                bool success = db.Insert(db);
                //db = new DatabaseConnection();
                //db.
                if (success == true)
                {
                    MessageBox.Show("Successful insert");

                }
                else
                {
                    MessageBox.Show("Failed to insert");

                }

            }

        }
    }
}
