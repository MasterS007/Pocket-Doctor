﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormDoctor : Form
    {
        //  List<Panel> listPanel = new List<Panel>();
        //int index;
        Patient p;
        PatientRepo prepo = new PatientRepo();
        UserControlProfile userProf = new UserControlProfile();
        AppointmentRepo arepo = new AppointmentRepo();
        public FormDoctor()
        {
            InitializeComponent();
            p = new Patient();
            this.timerD.Start();
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
                    this.pctUpload.ImageLocation = imageLocation;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error ocurred","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
           
          //  userProf.Hide();
            this.dgvPatientInfor.Hide();
            this.pnlMove1.Hide();
            this.pnlMove2.Hide();
           // this.pnlMove3.Hide();

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //ucMedicinecs1.Hide();
            // ucPaitent1.Hide();
            //ucTest1.Hide();
            // ucHome1.Show();
            // ucHome1.BringToFront();
            this.pnlMove1.Hide();
            this.pnlMove2.Hide();
         //   this.pnlMove3.Hide();
            this.pnlMove.Show();


        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            this.pnlDoctor.Controls.Add(userProf);
            userProf.Show();
            this.pnlMove.Hide();
            this.pnlMove2.Hide();
           // this.pnlMove3.Hide();
            this.pnlMove1.Show();
            this.dgvPatientInfor.Hide();
            

        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            userProf.Hide();
            this.dgvPatientInfor.Show();

            DataTable dataT = arepo.GetAppointtedPatient();

            this.dgvPatientInfor.DataSource = dataT;
            this.pnlMove1.Hide();
            this.pnlMove.Hide();
           // this.pnlMove3.Hide();
            this.pnlMove2.Show();


        }

       

     /*   private void PicbSearch_Click(object sender, EventArgs e)
        {
            string keyWord = txtSearchP.Text;
            DataTable dset = prepo.SearchPatient(keyWord);
            this.dgvPatientInfo.DataSource = dset;

        }*/

        private void TxtSearchP_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtSearchP.Text;
            DataTable dset = prepo.SearchPatient(keyWord);
            this.dgvPatientInfor.DataSource = dset;
        }

        public string daTe;
        private void Timer1_Tick(object sender, EventArgs e)
        {

            DateTime dateT = DateTime.Now;
            this.lbTime.Text = dateT.ToLongTimeString();
           daTe = dateT.ToShortDateString();
            this.lblDate.Text = dateT.ToLongDateString();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin flog = new FormLogin();
            flog.Visible = true;
        }
    }
}
