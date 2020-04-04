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
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           // dgvPatientPro.Show();
            
            DataTable dataT = p.GetPatient();
            dgvPatientPro.DataSource = dataT;
        }

        private void PicbSearch_Click(object sender, EventArgs e)
        {
                string keyWord = txtSearch.Text;
                DataTable dset = p.SearchPatient(keyWord);
                dgvPatientPro.DataSource = dset;
                   
        }

        private void FormReceptonist_Load(object sender, EventArgs e)
        {
           
            dgvPatientPro.Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;



            DataTable dset = p.SearchPatient(keyWord);
            dgvPatientPro.DataSource = dset;
        }
    }
}
