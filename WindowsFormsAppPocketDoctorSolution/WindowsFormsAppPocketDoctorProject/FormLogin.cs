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
           
           // DataSet dataSet = new DataSet();

            if (dataTable == true)
            {
                 string role;
                 DatabaseConnection db = new DatabaseConnection();
                 SqlConnection conn = db.ConnectDB();


                 string select = "SELECT userrole FROM tbl_User WHERE id='"+txtUserId.Text+"'";
                 SqlCommand cmd1 = new SqlCommand(select, conn);
                // cmd1.Parameters.AddWithValue("@userid", txtUserId);
                 //SqlDataReader myReader1 = cmd1.ExecuteReader();
                 var queryResult = cmd1.ExecuteScalar();


                if (queryResult != null)
                {
                    role = Convert.ToString(queryResult);
                    
                    if (role.Equals("Doctor"))
                    {
                        this.Visible = false;
                        FormHome fm = new FormHome();
                        fm.Visible = true;

                    }
                }

                else
                {
                      role = "";
                    }
                      conn.Close();
                


                }
            else
            {

                MessageBox.Show("Invalid password or user id");
                txtPassword.Clear();
                txtUserId.Clear();
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
