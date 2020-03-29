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
    public partial class FormLogin : Form
    {
        User users= new User();
        public FormLogin()
        {
            InitializeComponent();
        }



        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            // this.Visible = false;
            // FormHome fm = new FormHome();
            // fm.Visible = true;
            users.UserId = txtUserId.Text;
            users.Password = txtPassword.Text;
            DataTable dataTable = users.SelectUser(users);
            if (dataTable.Rows.Count == 1)
            {
                this.Visible = false;
                FormHome fm = new FormHome();
                fm.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid password or user id");
            }
        }

       
    }
}
