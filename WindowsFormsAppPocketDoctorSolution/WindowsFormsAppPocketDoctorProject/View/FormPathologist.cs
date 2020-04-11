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

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPathologist : Form
    {
        public FormPathologist()
        {
            InitializeComponent();
            timerT.Start();
        }

        private void TimerT_Tick(object sender, EventArgs e)
        {
            DateTime dateT = DateTime.Now;
            this.lblDate.Text = dateT.ToLongDateString();
            this.lbTime.Text = dateT.ToLongTimeString();
        }
    }
}
