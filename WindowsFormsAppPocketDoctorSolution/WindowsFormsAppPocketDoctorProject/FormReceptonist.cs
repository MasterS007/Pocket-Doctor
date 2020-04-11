using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.View;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormReceptonist : Form
    {
        Patient p = new Patient();
        DatabaseConnection DB { get; set; }
       


        public FormReceptonist()
        {
            InitializeComponent();
            p = new Patient();
            timerR.Start();
        }


       /* private void PicbSearch_Click(object sender, EventArgs e)
        {
                string keyWord = txtSearch.Text;
                DataTable dataT = p.SearchPatient(keyWord);
                dgvPatientPro.DataSource = dataT;
                   
        }*/

       

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            DataTable dset = p.SearchPatient(keyWord);
            this.PopulatedDataGridView(dset);
            
        }

        private void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvPatientPro.AutoGenerateColumns = false;
            this.dgvPatientPro.DataSource = dataT;
        }

      

        private void TimerR_Tick(object sender, EventArgs e)
        {
            DateTime dateT = DateTime.Now;
            this.lbTime.Text = dateT.ToLongTimeString();
            this.lblDate.Text = dateT.ToLongDateString();
        }

        private void FormReceptonist_Load(object sender, EventArgs e)
        {
            DataTable dataT = p.GetPatient();
            //sda = DB.Sda;
            this.PopulatedDataGridView(dataT); 

        }

        private void FormReceptonist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            p.PId = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["pid"].Value.ToString());
            p.Name = this.dgvPatientPro.CurrentRow.Cells["name"].Value.ToString();
            p.Gender = this.dgvPatientPro.CurrentRow.Cells["gender"].Value.ToString();
            p.Age = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["age"].Value.ToString());
            p.MobileNumber = this.dgvPatientPro.CurrentRow.Cells["mobilenumber"].Value.ToString();

            //MessageBox.Show(p.PId +" ");

            if(MessageBox.Show("Do you want to update?","Row Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                bool succeed = p.UpdatePatient(p);

                if (succeed == true)
                {

                    DataTable dataT = p.GetPatient();
                    this.PopulatedDataGridView(dataT);
                    MessageBox.Show(p.Name + " is updated");
                }
                else
                {
                    MessageBox.Show(p.Name + " is not updated");
                }
            }
            else
            {
                MessageBox.Show(p.Name + " is not updated", "Row Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
          

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
          
            p.PId = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["pid"].Value.ToString());
            p.Name = this.dgvPatientPro.CurrentRow.Cells["name"].Value.ToString();
           
            if (MessageBox.Show("Do you want to delete?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool succeed = p.DeletePatient(p);
                if(succeed == true)
                {
                    DataTable dataT = p.GetPatient();
                    this.PopulatedDataGridView(dataT);
                    MessageBox.Show(p.Name + " is Deleted");

                }

                else
                {
                    MessageBox.Show(p.Name + " is not Deleted");
                }

            }

            else
            {
                MessageBox.Show(p.Name + " is not deleted", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void PcbRefresh_Click(object sender, EventArgs e)
        {
            DataTable dataT = p.GetPatient();
            //sda = DB.Sda;
            this.PopulatedDataGridView(dataT);

        }

        private void BtnCreatePatient_Click(object sender, EventArgs e)
        {
            FormPatient fp = new FormPatient();
            fp.Show();
        }
    }
}
