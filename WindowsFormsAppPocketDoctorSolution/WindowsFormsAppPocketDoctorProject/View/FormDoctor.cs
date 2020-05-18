using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Data_Layer;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

using pdftron;
using pdftron.Common;
using pdftron.SDF;
using pdftron.PDF;
using System.Diagnostics;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormDoctor : Form
    {
        Patient p;
        bool btnHomeFlag = false;
        bool btnPatientFlag = false;
        PatientRepo prepo = new PatientRepo();
        UserControlProfile userProf = new UserControlProfile();
        UserControlPatientHis phistory = new UserControlPatientHis();
        AppointmentRepo arepo = new AppointmentRepo();
        DoctorRepo docRepo = new DoctorRepo();
        DatabaseConnection dbCon = DatabaseConnection.GetDbInstance();
        private static PDFNetLoader loader = PDFNetLoader.Instance();
        PatientHistoryRepo hrepo = new PatientHistoryRepo();
        public DateTime dateT = DateTime.Now;
        public FormDoctor()
        {
            InitializeComponent();
            PDFNet.Initialize();
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
            
            DataTable dataT = arepo.GetAppointtedPatient(dateT);
            this.PopulatedDataGridView(dataT);
            this.dgvPatientInfor.Show();
           // this.pnlDoctor.Controls.Add(phistory);
            userProf.Hide();
            phistory.Hide();
            this.btnDownlaod.Hide();
            this.btnUpload.Show();
            this.pnlMove1.Hide();
            this.pnlMove2.Hide();
           
        }

        private bool PatientProfile()
        {
            this.btnPatientFlag = true;
            this.pnlDoctor.Controls.Add(phistory);
          //  phistory.GetPatientHistory();
            phistory.Show();
            this.btnDownlaod.Show();
            this.btnUpload.Hide();
            userProf.Hide();
            lblApList.Hide();
            this.dgvPatientInfor.Hide();
            this.pnlMove1.Hide();
            this.pnlMove.Hide();
            this.pnlMove2.Show();
            return btnPatientFlag;

        }
        private bool Home()
        {
            this.btnHomeFlag = true;
            this.lblApList.Show();
            this.btnDownlaod.Hide();
            this.btnUpload.Show();
            this.dgvPatientInfor.Show();
            userProf.Hide();
            phistory.Hide();
            this.pnlMove1.Hide();
            this.pnlMove2.Hide();
            this.pnlMove.Show();

            return btnHomeFlag;
        }
      
        private void DoctorProfile()
        {
            this.btnDownlaod.Hide();

            lblApList.Hide();
            this.pnlDoctor.Controls.Add(userProf);
            userProf.Show();
            phistory.Hide();
            this.dgvPatientInfor.Hide();
            this.pnlMove.Hide();
            this.pnlMove2.Hide();
            this.pnlMove1.Show();
            this.dgvPatientInfor.Hide();
        }
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            this.DoctorProfile();
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Home();

        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            this.PatientProfile();

        }

        private void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvPatientInfor.AutoGenerateColumns = false;
            this.dgvPatientInfor.ClearSelection();
            this.dgvPatientInfor.DataSource = dataT;
             this.dgvPatientInfor.Refresh();
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

            if ( this.btnPatientFlag==true)

            {
              
                DataTable daset = hrepo.SearchPrescriptionHistory(keyWord);
                phistory.dgvPatientHistory.DataSource = daset;
            }
            else if(this.btnPatientFlag ==false)
            {
                
                DataTable dset = arepo.SearchAppointedPatient(keyWord, dateT);
                this.PopulatedDataGridView(dset);
            }
            
        }


        public string daTe;
        private void Timer1_Tick(object sender, EventArgs e)
        {
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
            fp.lblMobile.Text = dt.Rows[dt.Rows.Count - 1]["mobilenumber"].ToString();

            fp.txtPatientName.Text = this.dgvPatientInfor.CurrentRow.Cells["name"].Value.ToString();
            fp.txtPId.Text = this.dgvPatientInfor.CurrentRow.Cells["p_id"].Value.ToString();
            fp.txtGender.Text = this.dgvPatientInfor.CurrentRow.Cells["gender"].Value.ToString();
            fp.txtAge.Text = this.dgvPatientInfor.CurrentRow.Cells["age"].Value.ToString();
            DateTime daate = System.Convert.ToDateTime(this.dgvPatientInfor.CurrentRow.Cells["visiting_date"].Value.ToString());
            fp.txtDate.Text = daate.ToShortDateString();
            fp.Show();
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
            try
            {
                this.CreatePrescription();
            }
            catch(Exception ex) { MessageBox.Show(ex+""); }
        }

        private void RefreshConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataT = arepo.GetAppointtedPatient(dateT); 
            this.PopulatedDataGridView(dataT);
           

        }

       
        private void NewPrescriptionMenu_Click(object sender, EventArgs e)
        {
            FormPrescription fp = new FormPrescription();
            DataTable dt = docRepo.GetDoctorInfo();

            fp.lblDocName.Text = dt.Rows[dt.Rows.Count - 1]["username"].ToString();
            fp.lblEdu.Text = dt.Rows[dt.Rows.Count - 1]["edu_background"].ToString();
            fp.lblCatagory.Text = dt.Rows[dt.Rows.Count - 1]["dr_catagory"].ToString();
            fp.lblMobile.Text = dt.Rows[dt.Rows.Count - 1]["mobilenumber"].ToString();
            fp.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormLogin flog = new FormLogin();
            flog.Visible = true;
        }

        private void EditDoctorProfileMenu_Click(object sender, EventArgs e)
        {
            FormEditProfile fe = new FormEditProfile();
            fe.Visible = true;

        }

        private void ViewDoctorProfileMenu_Click(object sender, EventArgs e)
        {
            this.DoctorProfile();
            
        }

        private void ViewHomeMenu_Click(object sender, EventArgs e)
        {
            this.Home();
           
        }

        private void ViewPatienProfileMenu_Click(object sender, EventArgs e)
        {
            this.PatientProfile();
            
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            

            string filename="";
            string fileLocation= "";
            try
            {
                openFile.Filter = "PDF Files|*.pdf|All files(*.*)|*.*";
                if (this.dgvPatientInfor.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");
                    
                }

                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string docid = FormLogin.uid;
                    MemoryStream ms = new MemoryStream();
                    FileStream fs = File.OpenRead(openFile.FileName);
                    fileLocation = openFile.FileName;
                    filename = fileLocation.Substring(System.Convert.ToInt32(fileLocation.LastIndexOf("\\")) + 1, fileLocation.Length - (System.Convert.ToInt32(fileLocation.LastIndexOf("\\")) + 1));
                    fs.CopyTo(ms);
                    string pid = dgvPatientInfor.CurrentRow.Cells["p_id"].Value.ToString();
                    bool isSucceed = hrepo.InsertPrescription(pid, filename, ms, docid);

                    if(isSucceed == true)
                    {
                        var dt = hrepo.GetPatientHistory();
                        phistory.PopulatedDataGridView(dt);
                        MessageBox.Show("Inserted");
                    }
                    else
                    {
                        MessageBox.Show(" Not Inserted");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during File Read " + ex.ToString());
            }


        }

        private void BtnDownlaod_Click(object sender, EventArgs e)
        {
            if (!phistory.dgvPatientHistory.CurrentRow.Selected)
            {
                MessageBox.Show("Please Select The File Column row First");

            }
            else
            {
                string fname = phistory.dgvPatientHistory.CurrentRow.Cells["p_filename"].Value.ToString();
                if (MessageBox.Show("Do you want to download?", "Download Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var dt = hrepo.GetPrescription(fname);
                        byte[] pData = (byte[])(dt.Rows[0]["prescription"]);
                        System.IO.File.WriteAllBytes("G:\\Aiub\\3-Spring(2019-2020)\\C#\\temp.pdf", pData);
                        Process p = new Process();
                        p.StartInfo.FileName = "G:\\Aiub\\3-Spring(2019-2020)\\C#\\temp.pdf"; //Open the file on PDF Reader
                        p.Start();
                        //MessageBox.Show(pData);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during File Write " + ex.ToString());
                    }
                }

                else
                {
                    MessageBox.Show("File is not downloaded", "Download Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            

        }

       
    }
}
