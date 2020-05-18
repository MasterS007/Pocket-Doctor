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
using WindowsFormsAppPocketDoctorProject.Data_Layer;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPrescription : Form
    {
        ReportRepo rrepo = new ReportRepo();
        MedicineRepo mrepo = new MedicineRepo();
        TestRepo trepo = new TestRepo();
        FormPrescriptiontoPDF fPdf = new FormPrescriptiontoPDF();
        List<string> checkedItems = new List<string>();
        public FormPrescription()
        {
            InitializeComponent();
            FillchkboxlistTest();
            FillchkListMedicine();
        }

        private void FillchkListMedicine()
        {
            DataTable dt = mrepo.GetMedicine();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chkListMedicine.Items.Add(dt.Rows[i]["name"].ToString());
            }
        }
        private void FillchkboxlistTest()
        {
            DataTable dt = trepo.GetTest();

            for(int i=0; i<dt.Rows.Count; i++)
            {
                chkListTest.Items.Add(dt.Rows[i]["tname"].ToString());
            }
        }

        internal void fillMedicineList()
        {

            int i = 1;
            fPdf.listBoxMedicine.Items.Clear();

            foreach (string s in this.chkListMedicine.CheckedItems)
            {

                fPdf.listBoxMedicine.Items.Add(i.ToString() + "." + s);
                i++;

            }
        }
        internal void fillTestList()
        {

            int i = 1;
            fPdf.listBoxTest.Items.Clear();
           
           foreach(string s in this.chkListTest.CheckedItems)
            {
                
                fPdf.listBoxTest.Items.Add(i.ToString()+"."+s);
                i++;
           
            }
        }
        
       

        private void BtnSave_Click(object sender, EventArgs e)
        {

            foreach (string s in this.chkListTest.CheckedItems)
            {
                this.checkedItems.Add(s);
            }
                bool succeed = rrepo.InsertTest(this.txtPId.Text,this.checkedItems);

                if (succeed == true)
                {
                    MessageBox.Show(" Test is inserted");
                }
                else
                {
                    MessageBox.Show("Test is not inserted");
                } 
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
            this.fillMedicineList();

             

            this.Hide();
          
            fPdf.Show();
        }
    }
}
