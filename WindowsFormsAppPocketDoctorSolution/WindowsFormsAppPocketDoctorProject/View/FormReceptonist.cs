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
using WindowsFormsAppPocketDoctorProject.View;
using WindowsFormsAppPocketDoctorProject.Repository_Class;
using MetroFramework.Forms;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormReceptonist :Form
    {
        Patient p;
        PatientRepo prepo = new PatientRepo();
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
            DataTable dset = prepo.SearchPatient(keyWord);
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
            DataTable dataT = prepo.GetPatient();
            //sda = DB.Sda;
            this.PopulatedDataGridView(dataT); 

        }

        private void FormReceptonist_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        } 

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            p.pid = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["pid"].Value.ToString());
            p.name = this.dgvPatientPro.CurrentRow.Cells["name"].Value.ToString();
            p.gender = this.dgvPatientPro.CurrentRow.Cells["gender"].Value.ToString();
            p.age = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["age"].Value.ToString());
            p.mobilenumber = this.dgvPatientPro.CurrentRow.Cells["mobilenumber"].Value.ToString();
            p.bloodgroup = this.dgvPatientPro.CurrentRow.Cells["bloodgroup"].Value.ToString();

            //MessageBox.Show(p.PId +" ");

            if (MessageBox.Show("Do you want to update?","Row Update",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                bool succeed = prepo.UpdatePatient(p);

                if (succeed == true)
                {

                    DataTable dataT = prepo.GetPatient();
                    this.PopulatedDataGridView(dataT);
                    MessageBox.Show(p.name + " is updated");
                }
                else
                {
                    MessageBox.Show(p.name + " is not updated");
                }
            }
            else
            {
                MessageBox.Show(p.name + " is not updated", "Row Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
          

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
          
            p.pid = Convert.ToInt32(this.dgvPatientPro.CurrentRow.Cells["pid"].Value.ToString());
            p.name = this.dgvPatientPro.CurrentRow.Cells["name"].Value.ToString();
           
            if (MessageBox.Show("Do you want to delete?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool succeed = prepo.DeletePatient(p);
                if(succeed == true)
                {
                    DataTable dataT = prepo.GetPatient();
                    this.PopulatedDataGridView(dataT);
                    MessageBox.Show(p.name + " is Deleted");

                }

                else
                {
                    MessageBox.Show(p.name + " is not Deleted");
                }

            }

            else
            {
                MessageBox.Show(p.name + " is not deleted", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void PcbRefresh_Click(object sender, EventArgs e)
        {
            DataTable dataT = prepo.GetPatient();
            //sda = DB.Sda;
            this.PopulatedDataGridView(dataT);

        }

        private void BtnCreatePatient_Click(object sender, EventArgs e)
        {
            FormPatient fp = new FormPatient();
            fp.Show();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment f1 = new FormAppointment();

            f1.lblName.Text = this.dgvPatientPro.CurrentRow.Cells["name"].Value.ToString();
            f1.lblAge.Text = this.dgvPatientPro.CurrentRow.Cells["age"].Value.ToString();
            f1.lblBloodg.Text = this.dgvPatientPro.CurrentRow.Cells["bloodgroup"].Value.ToString();
            f1.lblGender.Text = this.dgvPatientPro.CurrentRow.Cells["gender"].Value.ToString();
            f1.Show();

        }
    }
}
