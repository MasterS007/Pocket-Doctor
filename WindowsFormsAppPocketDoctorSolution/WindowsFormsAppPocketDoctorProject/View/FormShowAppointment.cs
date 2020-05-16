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
    public partial class FormShowAppointment : Form
    {
        DoctorRepo drepo = new DoctorRepo();
        AppointmentRepo aprepo = new AppointmentRepo();
        Appointment a = new Appointment();
        public FormShowAppointment()
        {
            InitializeComponent();
         
        }

        private void FillComboBox()
        {
            DataTable dt = drepo.GetDoctor();
            for (int i = 0; i<dt.Rows.Count; i++ )
            {
                cmbDoctor.Items.Add(dt.Rows[i]["username"]+"|"+ dt.Rows[i]["dr_catagory"]);
            }
        }



        private void PopulatedDataGridView(DataTable dataT)
        {
            this.dgvAppointment.AutoGenerateColumns = false;
            this.dgvAppointment.DataSource = dataT;
            this.dgvAppointment.ClearSelection();
            this.dgvAppointment.Refresh();
        }

        private void FormShowAppointment_Load(object sender, EventArgs e)
        {
            DataTable dataT = aprepo.GetAppointment();
            //sda = DB.Sda;
            this.PopulatedDataGridView(dataT);
            this.FillComboBox();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string[] appointmentSearch = cmbDoctor.Text.Split('|');
            string docName = appointmentSearch[0];
            string categoryName = appointmentSearch[1];

            DateTime date = Convert.ToDateTime(dateTimeChoose.Text);
            DataTable dt = aprepo.SearchAppointment(docName, categoryName,date);
            this.PopulatedDataGridView(dt);
        }

       

        private void BtnCancelApp_Click(object sender, EventArgs e)
        {
            if(dgvAppointment.SelectedRows.Count!=1)
            {
                MessageBox.Show("Please select a row at first!");
            }

            a.appt_id = Convert.ToInt32(this.dgvAppointment.CurrentRow.Cells["appt_id"].Value.ToString());


            if (MessageBox.Show("Do you want to delete?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool succeed = aprepo.DeleteAppointment(a);
                if (succeed == true)
                {
                    DataTable dataT = aprepo.GetAppointment();
                    this.PopulatedDataGridView(dataT);
                    MessageBox.Show("Appointment is Canceld");

                }

                else
                {
                    MessageBox.Show("Appointment is not Canceled");
                }

            }

            else
            {
                MessageBox.Show("Appointment is not canceled", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
