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
    public partial class FormShowReport : Form
    {
        ReportRepo rrepo = new ReportRepo();
        public FormShowReport()
        {
            InitializeComponent();
            ShowReport();
        }

      

        private void ShowReport()
        {
            DataTable dt = rrepo.DisplayReport();
            this.PopulatedDataGridView(dt);
                 
        }

        
    
         private void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ClearSelection();
            this.dgvReport.DataSource = dataT;
            this.dgvReport.Refresh();
            
        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            

        }

        private void TxtSearchReport_TextChanged_1(object sender, EventArgs e)
        {
            string keyWord = this.txtSearchReport.Text;
            DataTable dset = rrepo.SearchReport(keyWord);
            this.PopulatedDataGridView(dset);
        }
    }
}
