﻿using System;
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

            if (this.cmbUserType.Text == "Doctor")
            {
                User userDoc = new Doctor(txtUserName.Text, txtPassword.Text, txtMobileNum.Text);

                bool success = userDoc.InsertUser(userDoc);
               
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
