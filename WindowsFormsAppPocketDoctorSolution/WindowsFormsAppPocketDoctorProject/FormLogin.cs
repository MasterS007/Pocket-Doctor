using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

      

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHome fm = new FormHome();
            fm.Visible = true;
        }

        private void LblSInUp_Click(object sender, EventArgs e)
        {

        }
    }
}
