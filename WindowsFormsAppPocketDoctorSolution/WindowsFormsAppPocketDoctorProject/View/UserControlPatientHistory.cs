using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Repository_Class;
using System.Diagnostics;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class UserControlPatientHis : UserControl
    {
        PatientHistoryRepo hrepo = new PatientHistoryRepo();
        public UserControlPatientHis()
        {
            InitializeComponent();
        }

       internal void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvPatientHistory.AutoGenerateColumns = false;
            this.dgvPatientHistory.ClearSelection();
            this.dgvPatientHistory.DataSource = dataT;
            this.dgvPatientHistory.Refresh();
        }

        internal void GetPatientHistory()
        {
            DataTable dataTable = hrepo.GetPatientHistory();
            this.PopulatedDataGridView(dataTable);
        }

        private void UserControlPatientHis_Load(object sender, EventArgs e)
        {
            this.GetPatientHistory();
        }


        int rowIndex = 0;
        private void DgvPatientHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPatientHistory.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.contextMenuSPatientPro.Show(this.dgvPatientHistory, e.Location);
                this.contextMenuSPatientPro.Show(Cursor.Position);

            }
        }

        private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvPatientHistory.CurrentRow.Selected || !this.dgvPatientHistory.CurrentRow.Cells["p_filename"].Selected)
            {
                MessageBox.Show("Please Select The File Column First");

            }
            else
            {
                string fname = this.dgvPatientHistory.CurrentRow.Cells["p_filename"].Value.ToString();
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

        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetPatientHistory();
        }
    }
}
