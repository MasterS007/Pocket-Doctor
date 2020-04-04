using System;
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
    public partial class FormHome : Form
    {
        //  List<Panel> listPanel = new List<Panel>();
        //int index;
        Patient p = new Patient();
        public FormHome()
        {
            InitializeComponent();
        }


        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
        private void LblUploadImg_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif| PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFile.FileName;
                    pctUpload.ImageLocation = imageLocation;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error ocurred","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

       

        private void FormHome_Load(object sender, EventArgs e)
        {
            /* ucMedicinecs1. ucPaitent1.Hide();
             ucTest1.Hide();*/
            dgvPatientInfo.Hide();
            pnlMove1.Hide();
            pnlMove2.Hide();
            pnlMove3.Hide();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //ucMedicinecs1.Hide();
            // ucPaitent1.Hide();
            //ucTest1.Hide();
            // ucHome1.Show();
            // ucHome1.BringToFront();
            pnlMove1.Hide();
            pnlMove2.Hide();
            pnlMove3.Hide();
            pnlMove.Show();


        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            pnlMove.Hide();
            pnlMove2.Hide();
            pnlMove3.Hide();
            pnlMove1.Show();
        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            /*  ucHome1.Hide();
            ucMedicinecs1.Hide();
            ucTest1.Hide();
             ucPaitent1.Show();
             ucPaitent1.BringToFront();*/
            dgvPatientInfo.Show();
            
            DataTable dataT = p.GetPatient();

            dgvPatientInfo.DataSource = dataT;
            pnlMove1.Hide();
            pnlMove.Hide();
            pnlMove3.Hide();
            pnlMove2.Show();


        }

        private void BtnPrescription_Click(object sender, EventArgs e)
        {
            /* ucHome1.Hide();
             ucPaitent1.Hide();
             ucTest1.Hide();
             ucMedicinecs1.Show();
            ucMedicinecs1.BringToFront();*/
            pnlMove1.Hide();
            pnlMove2.Hide();
            pnlMove.Hide();
            pnlMove3.Show();
        }

        private void PicbSearch_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearchP.Text;
            DataTable dset = p.SearchPatient(keyWord);
            dgvPatientInfo.DataSource = dset;

        }

        private void TxtSearchP_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtSearchP.Text;
            DataTable dset = p.SearchPatient(keyWord);
            dgvPatientInfo.DataSource = dset;
        }
    }
}
