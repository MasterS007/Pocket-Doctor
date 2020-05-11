
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPocketDoctorProject.Entity_Class;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPatient : Form
    {
        Patient p = new Patient();
        PatientRepo prepo = new PatientRepo();

        public FormPatient()
        {
            InitializeComponent();
        }

        /* private void FormPatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
         }*/

        private void LoadAutoUserId()
        {
            int serial = prepo.AutoIDValue();
            prepo.P_Id = (++serial).ToString("d4");
            p.p_id = prepo.P_Id;

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            p.name = this.txtPatientName.Text;
            p.age = Convert.ToInt32(this.txtPatientAge.Text);
            p.bloodgroup = this.cmbBloodGroup.Text;
            if (this.rbFemale.Checked)
            {
                p.gender = this.rbFemale.Text;
            }
            else
            {
                p.gender = this.rbMale.Text;
            }
            p.mobilenumber = this.txtMobileNum.Text;

            bool succeed = prepo.InsertPatient(p,p.p_id);

            if (succeed == true)
            {
                MessageBox.Show(p.name + " is inserted");

                this.Visible = false;



            }
            else
            {
                MessageBox.Show(p.name + " is not inserted");
            }

        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            this.LoadAutoUserId();
        }
    }
}
