﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Classes;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormSignUp : Form
    {
        User users = new User();
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
            User userDoc = new Doctor(txtUserName.Text, txtPassword.Text, txtMobileNum.Text,cmbUserType.Text);
            User userReceptionist = new Receptionist (txtUserName.Text, txtPassword.Text, txtMobileNum.Text, cmbUserType.Text);


            if (this.cmbUserType.Text == "Doctor")
            {
            bool success= userDoc.InsertUser(userDoc);
               
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
                bool success = userReceptionist.InsertUser(userReceptionist);

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
    }
}