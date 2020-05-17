using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
