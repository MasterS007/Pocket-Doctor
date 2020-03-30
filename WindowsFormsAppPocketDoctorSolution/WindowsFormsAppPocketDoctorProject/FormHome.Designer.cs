namespace WindowsFormsAppPocketDoctorProject
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblPaitentProfile = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctUpload = new System.Windows.Forms.PictureBox();
            this.lblUploadImg = new System.Windows.Forms.Label();
            this.dtPatientInfo = new System.Windows.Forms.DataGridView();
            this.pocketdoctordbDataSet = new WindowsFormsAppPocketDoctorProject.pocketdoctordbDataSet();
            this.pocketdoctordbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketdoctordbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketdoctordbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtPatientInfo);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(218, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 672);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.Controls.Add(this.lblTest, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPaitentProfile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMedicine, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHome, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(168, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 39);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblTest
            // 
            this.lblTest.AccessibleDescription = "";
            this.lblTest.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(352, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(168, 22);
            this.lblTest.TabIndex = 2;
            this.lblTest.Text = "Diagnostic Test";
            this.lblTest.Click += new System.EventHandler(this.LblTest_Click_1);
            // 
            // lblPaitentProfile
            // 
            this.lblPaitentProfile.AccessibleDescription = "";
            this.lblPaitentProfile.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaitentProfile.Location = new System.Drawing.Point(129, 0);
            this.lblPaitentProfile.Name = "lblPaitentProfile";
            this.lblPaitentProfile.Size = new System.Drawing.Size(201, 22);
            this.lblPaitentProfile.TabIndex = 0;
            this.lblPaitentProfile.Text = "Paitent\'s Profile";
            this.lblPaitentProfile.Click += new System.EventHandler(this.LblPaitentProfile_Click);
            // 
            // lblMedicine
            // 
            this.lblMedicine.AccessibleDescription = "";
            this.lblMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMedicine.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMedicine.Location = new System.Drawing.Point(575, 0);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(129, 22);
            this.lblMedicine.TabIndex = 1;
            this.lblMedicine.Text = "Medicine";
            this.lblMedicine.Click += new System.EventHandler(this.LblMedicine_Click_1);
            // 
            // lblHome
            // 
            this.lblHome.AccessibleDescription = "";
            this.lblHome.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(3, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(120, 22);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.LblHome_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.pctUpload);
            this.panel2.Controls.Add(this.lblUploadImg);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 672);
            this.panel2.TabIndex = 1;
            // 
            // pctUpload
            // 
            this.pctUpload.Image = ((System.Drawing.Image)(resources.GetObject("pctUpload.Image")));
            this.pctUpload.Location = new System.Drawing.Point(3, 3);
            this.pctUpload.Name = "pctUpload";
            this.pctUpload.Size = new System.Drawing.Size(192, 137);
            this.pctUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpload.TabIndex = 0;
            this.pctUpload.TabStop = false;
            // 
            // lblUploadImg
            // 
            this.lblUploadImg.AutoSize = true;
            this.lblUploadImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImg.ForeColor = System.Drawing.Color.Coral;
            this.lblUploadImg.Location = new System.Drawing.Point(36, 143);
            this.lblUploadImg.Name = "lblUploadImg";
            this.lblUploadImg.Size = new System.Drawing.Size(122, 22);
            this.lblUploadImg.TabIndex = 0;
            this.lblUploadImg.Text = "upload image";
            this.lblUploadImg.Click += new System.EventHandler(this.LblUploadImg_Click);
            // 
            // dtPatientInfo
            // 
            this.dtPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPatientInfo.Location = new System.Drawing.Point(175, 142);
            this.dtPatientInfo.Name = "dtPatientInfo";
            this.dtPatientInfo.RowTemplate.Height = 24;
            this.dtPatientInfo.Size = new System.Drawing.Size(729, 386);
            this.dtPatientInfo.TabIndex = 9;
            // 
            // pocketdoctordbDataSet
            // 
            this.pocketdoctordbDataSet.DataSetName = "pocketdoctordbDataSet";
            this.pocketdoctordbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pocketdoctordbDataSetBindingSource
            // 
            this.pocketdoctordbDataSetBindingSource.DataSource = this.pocketdoctordbDataSet;
            this.pocketdoctordbDataSetBindingSource.Position = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketdoctordbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocketdoctordbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUploadImg;
        private System.Windows.Forms.PictureBox pctUpload;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Label lblPaitentProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtPatientInfo;
        private System.Windows.Forms.BindingSource pocketdoctordbDataSetBindingSource;
        private pocketdoctordbDataSet pocketdoctordbDataSet;
    }
}