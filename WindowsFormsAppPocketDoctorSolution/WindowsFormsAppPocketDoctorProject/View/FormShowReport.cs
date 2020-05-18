using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (this.dgvReport.CurrentRow.Selected || this.dgvReport.CurrentRow.Cells["rep_name"].Selected)
            {
                string fname = this.dgvReport.CurrentRow.Cells["rep_name"].Value.ToString();
                string pid = this.dgvReport.CurrentRow.Cells["p_id"].Value.ToString();
                if (MessageBox.Show("Do you want to download?", "Download Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var dt = rrepo.DownloadReport(fname, pid);
                        byte[] pData = (byte[])(dt.Rows[0]["report"]);
                        System.IO.File.WriteAllBytes("G:\\Aiub\\3-Spring(2019-2020)\\C#\\temprep.pdf", pData);
                        Process p = new Process();
                        p.StartInfo.FileName = "G:\\Aiub\\3-Spring(2019-2020)\\C#\\temprep.pdf"; //Open the file on PDF Reader
                        p.Start();

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
            else
            {
                MessageBox.Show("Please Select The File row First");
            }


        }

        private void TxtSearchReport_TextChanged_1(object sender, EventArgs e)
        {
            string keyWord = this.txtSearchReport.Text;
            DataTable dset = rrepo.SearchReport(keyWord);
            this.PopulatedDataGridView(dset);
        }
    }
}
