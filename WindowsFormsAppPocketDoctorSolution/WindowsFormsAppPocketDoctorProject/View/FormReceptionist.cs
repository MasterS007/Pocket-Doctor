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

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormReceptionist : Form
    {
        public FormReceptionist()
        {
            InitializeComponent();
        }

        private void TblpnlGetPatient_Paint(object sender, PaintEventArgs e)
        {
            Patient p = new Patient();
            DataTable dataT = p.GetPatient();

          // tblpnlGetPatient.D
        }
    }
}
