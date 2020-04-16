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
    public partial class FormAppointment : Form
    {
        DoctorRepo docRepo = new DoctorRepo();
       
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

       

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            DataTable dataT = docRepo.GetDoctor();
            this.PopulateDataGeidView(dataT);
        }

        private void PopulateDataGeidView(DataTable dataT)
        {
            dgvDoctor.AutoGenerateColumns = false;
            dgvDoctor.DataSource = dataT;

        }

        private void CmbDocCategorty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbDocCategorty.Text;
            if(cmbDocCategorty.SelectedItem.ToString()== category)
            {
                DataTable dataT =docRepo.SearchDoctor(category);
                this.PopulateDataGeidView(dataT);
            }

            else { MessageBox.Show("No such category exist!"); }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dataT = docRepo.SearchDoctor(txtSearch.Text);
            this.PopulateDataGeidView(dataT);
        }

        private void PicbSearch_Click(object sender, EventArgs e)
        {
            DataTable dataT = docRepo.SearchDoctor(txtSearch.Text);
            this.PopulateDataGeidView(dataT);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DoctorPatient dp = new DoctorPatient();
            DoctorPatientRepo docp = new DoctorPatientRepo();

            
            dp.dr_id = Convert.ToInt32(this.dgvDoctor.CurrentRow.Cells["id"].Value.ToString());
            dp.p_id = Convert.ToInt32(this.lblPId.Text);
            
            dp.visiting_date =Convert.ToDateTime(lblDate.Text);
            bool succeed = docp.InsertRow(dp);


            if (succeed == true)
            {
                MessageBox.Show("inserted");
                
                this.Visible = false;

            }
            else
            {
                MessageBox.Show(dp.visiting_date+"not inserted");
            }

        }
    }
}
