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
using WindowsFormsAppPocketDoctorProject.Classes;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormReceptonist : Form
    {
        Patient p = new Patient();
        DatabaseConnection db;
        public FormReceptonist()
        {
            InitializeComponent();
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

        private void FormReceptonist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            this.PopulatedDataGridView(dataT);
          

        }
    }
}
