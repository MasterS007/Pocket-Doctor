using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPathologist : Form
    {
        ReportRepo rrepo = new ReportRepo();
        PatientHistoryRepo hrepo = new PatientHistoryRepo();
        public FormPathologist()
        {
            InitializeComponent();
            GetPatientTest();
            timerT.Start();
        }

        private void TimerT_Tick(object sender, EventArgs e)
        {
            DateTime dateT = DateTime.Now;
            this.lblDate.Text = dateT.ToLongDateString();
            this.lbTime.Text = dateT.ToLongTimeString();
        }

        private void FormPathologist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvTest.AutoGenerateColumns = false;
            this.dgvTest.ClearSelection();
            this.dgvTest.DataSource = dataT;
            this.dgvTest.Refresh();

        }

        private void InsertRepDate()
        {
            string pid = this.dgvTest.CurrentRow.Cells["p_id"].Value.ToString();
            string tname = this.dgvTest.CurrentRow.Cells["tname"].Value.ToString();
            DateTime issuedate = Convert.ToDateTime(this.dgvTest.CurrentRow.Cells["issue_date"].Value.ToString());
            DateTime duedate = Convert.ToDateTime(this.dgvTest.CurrentRow.Cells["due_date"].Value.ToString());
            var isSucceed = rrepo.InsertReportDate(pid,tname,issuedate,duedate);

            if(isSucceed == true)
            {
                MessageBox.Show("inserted");

            }
            else
            {
                MessageBox.Show("not inserted");


            }

        }
        private void GetPatientTest()
        {
            DataTable dt = rrepo.GetReport();
            this.PopulatedDataGridView(dt);
        }
       
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            this.InsertRepDate();
            this.GetPatientTest();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin flog = new FormLogin();
            flog.Visible = true;
            this.Hide();

        }

        private void BtnUploadRep_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();


            string filename = "";
            string fileLocation = "";
            try
            {
                openFile.Filter = "PDF Files|*.pdf|All files(*.*)|*.*";
                if (this.dgvTest.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please Select A Row First");

                }

                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MemoryStream ms = new MemoryStream();
                    FileStream fs = File.OpenRead(openFile.FileName);
                    fileLocation = openFile.FileName;
                    filename = fileLocation.Substring(System.Convert.ToInt32(fileLocation.LastIndexOf("\\")) + 1, fileLocation.Length - (System.Convert.ToInt32(fileLocation.LastIndexOf("\\")) + 1));
                    fs.CopyTo(ms);
                    string pid = this.dgvTest.CurrentRow.Cells["p_id"].Value.ToString();
                    string tname = this.dgvTest.CurrentRow.Cells["tname"].Value.ToString();
                    bool isSucceed = rrepo.InsertTestReport(pid,tname, filename, ms);

                    if (isSucceed == true)
                    {
                        var dt = rrepo.DisplayReport();
                        this.PopulatedDataGridView(dt);
                        
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
    }
}
