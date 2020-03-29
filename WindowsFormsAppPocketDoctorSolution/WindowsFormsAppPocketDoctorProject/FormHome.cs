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
    public partial class FormHome : Form
    {
      //  List<Panel> listPanel = new List<Panel>();
        //int index;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LblUploadImg_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif| PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFile.FileName;
                    pctUpload.ImageLocation = imageLocation;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error ocurred","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void LblHome_Click(object sender, EventArgs e)
        {
             ucMedicinecs1.Hide();
              ucPaitent1.Hide();
              ucTest1.Hide();
              ucHome1.Show();
              ucHome1.BringToFront();

        }
      
     

        private void LblPaitentProfile_Click(object sender, EventArgs e)
        {
              ucHome1.Hide();
             ucMedicinecs1.Hide();
             ucTest1.Hide();
              ucPaitent1.Show();
              ucPaitent1.BringToFront();

        }
        private void LblTest_Click_1(object sender, EventArgs e)
        {
            ucHome1.Hide();
            ucMedicinecs1.Hide();
            ucPaitent1.Hide();
            ucTest1.Show();
            ucTest1.BringToFront();


        }

        private void LblMedicine_Click_1(object sender, EventArgs e)
        {
             ucHome1.Hide();
             ucPaitent1.Hide();
             ucTest1.Hide();
             ucMedicinecs1.Show();
            ucMedicinecs1.BringToFront();


        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            ucMedicinecs1.Hide();
            ucPaitent1.Hide();
            ucTest1.Hide();

        }
    }
}
