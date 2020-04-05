using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsAppPocketDoctorProject.Classes;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormLogin : Form
    {
        DatabaseConnection db;
        User users= new User();
        public FormLogin()
        {
            InitializeComponent();
        }   
          private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            users.UserId = Convert.ToInt32(txtUserId.Text);
            users.Password = txtPassword.Text;
             bool dataTable = users.SelectUser(users);
             if (dataTable == true)
            {
                 string role;
                 db = new DatabaseConnection();
                 string query = "SELECT userrole FROM tbl_User WHERE id='"+txtUserId.Text+"'";
                SqlCommand cmd1 = db.Query(query);
                 var queryResult= cmd1.ExecuteScalar();


                if (queryResult != null)
                {
                    role = Convert.ToString(queryResult);
                    
                    if (role.Equals("Doctor"))
                    {
                        this.Visible = false;
                        FormHome fm = new FormHome();
                        fm.Visible = true;

                    }

                    else if (role.Equals("Receptionist"))
                    {
                        this.Visible = false;
                        FormReceptonist fm = new FormReceptonist();
                        fm.Visible = true;

                    }
                }

                else
                {
                      role = "";
                }
                db.CloseConnection();
                }
            else
            {

                MessageBox.Show("Invalid password or user id");
                this.txtPassword.Clear();
                this.txtUserId.Clear();
            }
        }

        private void LblSInUp_Click(object sender, EventArgs e)
        {
              this.Visible = false;
              FormSignUp formSingUp = new FormSignUp();
              formSingUp.Show();

        }
    }
}
