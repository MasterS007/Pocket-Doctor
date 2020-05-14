namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormPrescriptiontoPDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrestoPdf = new System.Windows.Forms.Panel();
            this.listBoxMedicine = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPId = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMobileDoc = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblEdu = new System.Windows.Forms.Label();
            this.lblDocName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSavePDF = new System.Windows.Forms.Button();
            this.pnlPrestoPdf.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrestoPdf
            // 
            this.pnlPrestoPdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrestoPdf.BackColor = System.Drawing.Color.White;
            this.pnlPrestoPdf.Controls.Add(this.listBoxMedicine);
            this.pnlPrestoPdf.Controls.Add(this.label2);
            this.pnlPrestoPdf.Controls.Add(this.label3);
            this.pnlPrestoPdf.Controls.Add(this.listBoxTest);
            this.pnlPrestoPdf.Controls.Add(this.lblDate);
            this.pnlPrestoPdf.Controls.Add(this.label8);
            this.pnlPrestoPdf.Controls.Add(this.lblPId);
            this.pnlPrestoPdf.Controls.Add(this.label15);
            this.pnlPrestoPdf.Controls.Add(this.lblGender);
            this.pnlPrestoPdf.Controls.Add(this.label6);
            this.pnlPrestoPdf.Controls.Add(this.lblAge);
            this.pnlPrestoPdf.Controls.Add(this.label5);
            this.pnlPrestoPdf.Controls.Add(this.lblPatientName);
            this.pnlPrestoPdf.Controls.Add(this.label1);
            this.pnlPrestoPdf.Controls.Add(this.panel3);
            this.pnlPrestoPdf.Controls.Add(this.lblMobileDoc);
            this.pnlPrestoPdf.Controls.Add(this.lblCatagory);
            this.pnlPrestoPdf.Controls.Add(this.lblEdu);
            this.pnlPrestoPdf.Controls.Add(this.lblDocName);
            this.pnlPrestoPdf.Location = new System.Drawing.Point(5, 5);
            this.pnlPrestoPdf.Name = "pnlPrestoPdf";
            this.pnlPrestoPdf.Size = new System.Drawing.Size(812, 713);
            this.pnlPrestoPdf.TabIndex = 0;
            // 
            // listBoxMedicine
            // 
            this.listBoxMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMedicine.FormattingEnabled = true;
            this.listBoxMedicine.ItemHeight = 25;
            this.listBoxMedicine.Location = new System.Drawing.Point(458, 349);
            this.listBoxMedicine.Name = "listBoxMedicine";
            this.listBoxMedicine.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMedicine.Size = new System.Drawing.Size(312, 300);
            this.listBoxMedicine.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Medicine Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Test Name :";
            // 
            // listBoxTest
            // 
            this.listBoxTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTest.ForeColor = System.Drawing.Color.Black;
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.ItemHeight = 25;
            this.listBoxTest.Location = new System.Drawing.Point(41, 349);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxTest.Size = new System.Drawing.Size(302, 300);
            this.listBoxTest.TabIndex = 31;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(473, 195);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(273, 25);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "                     Date                       ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Date :";
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPId.Location = new System.Drawing.Point(340, 146);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(158, 25);
            this.lblPId.TabIndex = 28;
            this.lblPId.Text = "           Id               ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(297, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "ID:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(121, 195);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(182, 25);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "           Gender          ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Gender :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(645, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(153, 25);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "           Age          ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Age:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(91, 146);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(64, 25);
            this.lblPatientName.TabIndex = 22;
            this.lblPatientName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 20);
            this.panel3.TabIndex = 20;
            // 
            // lblMobileDoc
            // 
            this.lblMobileDoc.AutoSize = true;
            this.lblMobileDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileDoc.Location = new System.Drawing.Point(546, 83);
            this.lblMobileDoc.Name = "lblMobileDoc";
            this.lblMobileDoc.Size = new System.Drawing.Size(70, 25);
            this.lblMobileDoc.TabIndex = 19;
            this.lblMobileDoc.Text = "Mobile";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(546, 58);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(92, 25);
            this.lblCatagory.TabIndex = 18;
            this.lblCatagory.Text = "Category";
            // 
            // lblEdu
            // 
            this.lblEdu.AutoSize = true;
            this.lblEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdu.Location = new System.Drawing.Point(546, 33);
            this.lblEdu.Name = "lblEdu";
            this.lblEdu.Size = new System.Drawing.Size(224, 25);
            this.lblEdu.TabIndex = 5;
            this.lblEdu.Text = "Educational Background";
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocName.Location = new System.Drawing.Point(570, 0);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(155, 29);
            this.lblDocName.TabIndex = 4;
            this.lblDocName.Text = "Doctor Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSavePDF);
            this.panel2.Location = new System.Drawing.Point(5, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 107);
            this.panel2.TabIndex = 1;
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.Location = new System.Drawing.Point(522, 41);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.Size = new System.Drawing.Size(116, 45);
            this.btnSavePDF.TabIndex = 0;
            this.btnSavePDF.Text = "Save as Pdf";
            this.btnSavePDF.UseVisualStyleBackColor = true;
            this.btnSavePDF.Click += new System.EventHandler(this.BtnSavePDF_Click);
            // 
            // FormPrescriptiontoPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 836);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlPrestoPdf);
            this.Name = "FormPrescriptiontoPDF";
            this.Text = "FormPrescriptiontoPDF";
            this.Load += new System.EventHandler(this.FormPrescriptiontoPDF_Load);
            this.pnlPrestoPdf.ResumeLayout(false);
            this.pnlPrestoPdf.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrestoPdf;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label lblDocName;
        internal System.Windows.Forms.Label lblEdu;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblMobileDoc;
        internal System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblPatientName;
        internal System.Windows.Forms.Label lblAge;
        internal System.Windows.Forms.Label lblGender;
        internal System.Windows.Forms.Label lblPId;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.ListBox listBoxTest;
        internal System.Windows.Forms.ListBox listBoxMedicine;
        private System.Windows.Forms.Button btnSavePDF;
    }
}