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

        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //Panel grd = new Panel();
            Bitmap bmp = new Bitmap(pnlPrescription.Width, pnlPrescription.Height, pnlPrescription.CreateGraphics());
            bmp.SetResolution(1920, 1080);
            pnlPrescription.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, pnlPrescription.Width, pnlPrescription.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }
    }
}
