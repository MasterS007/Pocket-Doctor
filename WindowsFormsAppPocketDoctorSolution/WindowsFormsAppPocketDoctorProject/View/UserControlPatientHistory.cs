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
    }
}
