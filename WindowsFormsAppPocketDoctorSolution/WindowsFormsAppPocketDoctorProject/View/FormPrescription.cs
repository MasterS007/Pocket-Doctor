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

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPrescription : Form
    {
        public FormPrescription()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           /* Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 100f, 0f);
            SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PDF File |*.pdf", ValidateNames = true };
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();
               Paragraph p = new Paragraph("MONU PDF CREATE HOISE HEHEHEHE!!");
                document.Add(p);
                document.Close();

                PdfPTable pdtable = new PdfPTable(3);
                //pdtable.Rows
            }*/
            
        }
    }
}
