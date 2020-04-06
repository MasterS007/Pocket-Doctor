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
    public partial class FormPatient : Form
    {
        Patient p = new Patient();
        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            p.Name =this.txtPatientName.Text;
            p.Age = Convert.ToInt32(this.txtPatientAge.Text);
            if(this.rbFemale.Checked)
            {
                p.Gender = this.rbFemale.Text;
            }
            else
            {
                p.Gender = this.rbMale.Text;
            }
            p.MobileNumber = this.txtMobileNum.Text;

            bool succeed = p.InsertPatient(p);

            if (succeed == true)
            {
                MessageBox.Show(p.Name + " is inserted");
                this.Visible = false;


            }
            else
            {
                MessageBox.Show(p.Name + " is not inserted");
            }

        }
    }
}
