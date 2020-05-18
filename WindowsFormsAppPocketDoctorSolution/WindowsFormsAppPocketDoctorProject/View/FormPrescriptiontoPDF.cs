using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPocketDoctorProject.View
{
    public partial class FormPrescriptiontoPDF : Form
    {
        
        public FormPrescriptiontoPDF()
        {
            InitializeComponent();
            
        }

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            Bitmap bmp = new Bitmap(pnlPrestoPdf.Width,pnlPrestoPdf.Height, pnlPrestoPdf.CreateGraphics());
            bmp.SetResolution(150,150);
         
            pnlPrestoPdf.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, pnlPrestoPdf.Width, pnlPrestoPdf.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, bounds.Height);
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
            this.Dispose();

        }

       
        
    }
}
