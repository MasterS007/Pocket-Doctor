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
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Repository_Class;


namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormLogin : Form
    {
        public static string uid;
      
        UserRepo urepo = new UserRepo();
        DoctorRepo drepo = new DoctorRepo();
        UserControlProfile prof = new UserControlProfile();
        

        public FormLogin()
        {
            InitializeComponent();
            
        }
       
        
        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
            User users = new User();
            Doctor doc = new Doctor();
            users.UserId = txtUserId.Text;
            uid = txtUserId.Text;
            
            users.password = txtPassword.Text;
             var role = urepo.SelectUser(users);
           
             //if (dataTable == true)
          //  {
                /* string role;
                 string query = "SELECT userrole FROM tbl_User WHERE id='"+txtUserId.Text+"'";
                SqlCommand cmd1 = dbCon.Query(query);
                 var queryResult= cmd1.ExecuteScalar();
                 */

              //  if (queryResult != null)
              //  {
                 //   role = Convert.ToString(queryResult);
                
                    
                    if( role.Equals("D"))
                    {
                        this.Visible = false;
                        FormDoctor fm = new FormDoctor();
                        fm.Visible = true;
                        

                    }

                    else if (role.Equals("R"))
                    {
                        this.Visible = false;
                        FormReceptonist fm = new FormReceptonist();
                        fm.Visible = true;

                    }

                    else if (role.Equals("P"))
                    {
                        this.Visible = false;
                        FormPathologist fm = new FormPathologist();
                        fm.Visible = true;

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

       
        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
