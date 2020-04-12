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
    public partial class FormAppointment : Form
    {
        
        public FormAppointment()
        {
            InitializeComponent();
            timerAp.Start();
            
        }

        private void TimerAp_Tick(object sender, EventArgs e)
        {
            DateTime dateT = DateTime.Now;
            this.lblDate.Text = dateT.ToLongDateString();
        }
    }
}
