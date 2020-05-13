using System;
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
        DoctorRepo docRepo = new DoctorRepo();
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
            userProf.Hide();
            this.dgvPatientInfor.Hide();
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
               DataTable dset =  arepo.SearchAppointedPatient(keyWord);
               this.dgvPatientInfo.DataSource = dset;

           }*/

        private void TxtSearchP_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txtSearchP.Text;
            DataTable dset = arepo.SearchAppointedPatient(keyWord);
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
            this.Dispose();
            FormLogin flog = new FormLogin();
            flog.Visible = true;
        }

        private void CreatePrescription()
        {
            FormPrescription fp = new FormPrescription();
            DataTable dt = docRepo.GetDoctorInfo();

            fp.lblDocName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            fp.lblEdu.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            fp.lblCatagory.Text = dt.Rows[dt.Rows.Count - 1]["dr_catagory"].ToString();

            fp.txtPatientName.Text = this.dgvPatientInfor.CurrentRow.Cells["name"].Value.ToString();
            fp.txtPId.Text = this.dgvPatientInfor.CurrentRow.Cells["p_id"].Value.ToString();
            fp.txtGender.Text = this.dgvPatientInfor.CurrentRow.Cells["gender"].Value.ToString();
            fp.txtAge.Text = this.dgvPatientInfor.CurrentRow.Cells["age"].Value.ToString();
            DateTime daate = Convert.ToDateTime(this.dgvPatientInfor.CurrentRow.Cells["visiting_date"].Value.ToString());
            fp.txtDate.Text = daate.ToShortDateString();
            fp.Show();
        }
        private void PrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.CreatePrescription();
            FormPrescription fp = new FormPrescription();
            DataTable dt = docRepo.GetDoctorInfo();

            fp.lblDocName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            fp.lblEdu.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            fp.lblCatagory.Text = dt.Rows[dt.Rows.Count - 1]["dr_catagory"].ToString();
            fp.Show();
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormEditProfile fe = new FormEditProfile();
            fe.Visible = true;
        }

        private void ProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pnlDoctor.Controls.Add(userProf);
            userProf.Show();
            this.pnlMove.Hide();
            this.pnlMove2.Hide();
            
            this.pnlMove1.Show();
            this.dgvPatientInfor.Hide();
        }

        private void PatientProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userProf.Hide();
            this.dgvPatientInfor.Show();

            DataTable dataT = arepo.GetAppointtedPatient();

            this.dgvPatientInfor.DataSource = dataT;
            this.pnlMove1.Hide();
            this.pnlMove.Hide();
           
            this.pnlMove2.Show();
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            userProf.Hide();
            this.dgvPatientInfor.Hide();
            this.pnlMove1.Hide();
            this.pnlMove2.Hide();
           
            this.pnlMove.Show();
        }


        int rowIndex = 0;
        private void DgvPatientInfor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPatientInfor.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuStripDOc.Show(this.dgvPatientInfor, e.Location);
                this.contextMenuStripDOc.Show(Cursor.Position);

            }
        }

        private void PrescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.CreatePrescription();
        }

        private void RefreshConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataT = arepo.GetAppointtedPatient();

            this.dgvPatientInfor.DataSource = dataT;

        }

        

    }
}
