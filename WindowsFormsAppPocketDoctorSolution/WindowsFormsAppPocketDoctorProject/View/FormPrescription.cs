using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using WindowsFormsAppPocketDoctorProject.Repository_Class;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPrescription : Form
    {
        TestRepo trepo = new TestRepo();
        FormPrescriptiontoPDF fPdf = new FormPrescriptiontoPDF();
        public FormPrescription()
        {
            InitializeComponent();
            FillchkboxlistTest();
        }

        private void FillchkboxlistTest()
        {
            DataTable dt = trepo.GetTest();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                chkListTest.Items.Add(dt.Rows[i]["name"].ToString());
            }
        }
       

        internal void fillTestList()
        {

            int i = 1;
            fPdf.listBoxTest.Items.Clear();
           
           // MessageBox.Show(chkListTest.Items)
           foreach(string s in this.chkListTest.CheckedItems)
            {
                
                fPdf.listBoxTest.Items.Add(i.ToString()+"."+s);
                i++;
           
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            
            fPdf.lblDocName.Text = this.lblDocName.Text;
            fPdf.lblEdu.Text = this.lblEdu.Text;
            fPdf.lblCatagory.Text = this.lblCatagory.Text;
            fPdf.lblMobileDoc.Text = this.lblMobile.Text;
            fPdf.lblPatientName.Text = this.txtPatientName.Text;
            fPdf.lblPId.Text = this.txtPId.Text;
            fPdf.lblAge.Text = this.txtAge.Text;
            fPdf.lblGender.Text = this.txtGender.Text;
            fPdf.lblDate.Text = this.txtDate.Text;
            this.fillTestList();
           this.Hide();
          
            fPdf.Show();
        }


    }
}
