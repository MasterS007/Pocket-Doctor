﻿namespace WindowsFormsAppPocketDoctorProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbSearchP = new System.Windows.Forms.PictureBox();
            this.txtSearchP = new System.Windows.Forms.TextBox();
            this.dtPatientInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMove3 = new System.Windows.Forms.Panel();
            this.pnlMove2 = new System.Windows.Forms.Panel();
            this.pnlMove1 = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.pctUpload = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblUploadImg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearchP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtPatientInfo);
            this.panel1.Location = new System.Drawing.Point(231, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 778);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.PicbSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.PeachPuff;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(720, 708);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 30);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picbSearchP);
            this.panel3.Controls.Add(this.txtSearchP);
            this.panel3.Location = new System.Drawing.Point(458, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 69);
            this.panel3.TabIndex = 11;
            // 
            // picbSearchP
            // 
            this.picbSearchP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbSearchP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbSearchP.Image = ((System.Drawing.Image)(resources.GetObject("picbSearchP.Image")));
            this.picbSearchP.Location = new System.Drawing.Point(354, 19);
            this.picbSearchP.Name = "picbSearchP";
            this.picbSearchP.Size = new System.Drawing.Size(50, 34);
            this.picbSearchP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbSearchP.TabIndex = 11;
            this.picbSearchP.TabStop = false;
            this.picbSearchP.Click += new System.EventHandler(this.PicbSearch_Click);
            this.picbSearchP.MouseHover += new System.EventHandler(this.PicbSearch_Click);
            // 
            // txtSearchP
            // 
            this.txtSearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchP.Location = new System.Drawing.Point(44, 19);
            this.txtSearchP.Name = "txtSearchP";
            this.txtSearchP.Size = new System.Drawing.Size(304, 34);
            this.txtSearchP.TabIndex = 10;
            // 
            // dtPatientInfo
            // 
            this.dtPatientInfo.AllowUserToAddRows = false;
            this.dtPatientInfo.AllowUserToDeleteRows = false;
            this.dtPatientInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPatientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPatientInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtPatientInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtPatientInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtPatientInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPatientInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtPatientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtPatientInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtPatientInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dtPatientInfo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dtPatientInfo.Location = new System.Drawing.Point(4, 154);
            this.dtPatientInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dtPatientInfo.Name = "dtPatientInfo";
            this.dtPatientInfo.ReadOnly = true;
            this.dtPatientInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPatientInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtPatientInfo.RowHeadersVisible = false;
            this.dtPatientInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPatientInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtPatientInfo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtPatientInfo.RowTemplate.Height = 40;
            this.dtPatientInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtPatientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtPatientInfo.Size = new System.Drawing.Size(906, 525);
            this.dtPatientInfo.TabIndex = 9;
            this.dtPatientInfo.Tag = "";
            this.dtPatientInfo.VirtualMode = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.pnlMove3);
            this.panel2.Controls.Add(this.pnlMove2);
            this.panel2.Controls.Add(this.pnlMove1);
            this.panel2.Controls.Add(this.pnlMove);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnPatient);
            this.panel2.Controls.Add(this.btnPrescription);
            this.panel2.Controls.Add(this.pctUpload);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.lblUploadImg);
            this.panel2.Location = new System.Drawing.Point(12, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 778);
            this.panel2.TabIndex = 1;
            // 
            // pnlMove3
            // 
            this.pnlMove3.AutoScroll = true;
            this.pnlMove3.BackColor = System.Drawing.Color.Brown;
            this.pnlMove3.Location = new System.Drawing.Point(3, 557);
            this.pnlMove3.Name = "pnlMove3";
            this.pnlMove3.Size = new System.Drawing.Size(20, 71);
            this.pnlMove3.TabIndex = 15;
            // 
            // pnlMove2
            // 
            this.pnlMove2.AutoScroll = true;
            this.pnlMove2.BackColor = System.Drawing.Color.Brown;
            this.pnlMove2.Location = new System.Drawing.Point(5, 443);
            this.pnlMove2.Name = "pnlMove2";
            this.pnlMove2.Size = new System.Drawing.Size(20, 71);
            this.pnlMove2.TabIndex = 14;
            // 
            // pnlMove1
            // 
            this.pnlMove1.AutoScroll = true;
            this.pnlMove1.BackColor = System.Drawing.Color.Brown;
            this.pnlMove1.Location = new System.Drawing.Point(5, 334);
            this.pnlMove1.Name = "pnlMove1";
            this.pnlMove1.Size = new System.Drawing.Size(20, 71);
            this.pnlMove1.TabIndex = 13;
            // 
            // pnlMove
            // 
            this.pnlMove.AutoScroll = true;
            this.pnlMove.BackColor = System.Drawing.Color.Brown;
            this.pnlMove.Location = new System.Drawing.Point(5, 229);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(20, 71);
            this.pnlMove.TabIndex = 12;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(29, 229);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 71);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(29, 443);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(156, 71);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Patient Profile";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.FlatAppearance.BorderSize = 0;
            this.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.Location = new System.Drawing.Point(29, 560);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(156, 68);
            this.btnPrescription.TabIndex = 5;
            this.btnPrescription.Text = "New Prescription";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Click += new System.EventHandler(this.BtnPrescription_Click);
            // 
            // pctUpload
            // 
            this.pctUpload.Image = ((System.Drawing.Image)(resources.GetObject("pctUpload.Image")));
            this.pctUpload.Location = new System.Drawing.Point(5, 0);
            this.pctUpload.Name = "pctUpload";
            this.pctUpload.Size = new System.Drawing.Size(192, 137);
            this.pctUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpload.TabIndex = 0;
            this.pctUpload.TabStop = false;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(29, 334);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(130, 71);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // lblUploadImg
            // 
            this.lblUploadImg.AutoSize = true;
            this.lblUploadImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImg.ForeColor = System.Drawing.Color.Coral;
            this.lblUploadImg.Location = new System.Drawing.Point(37, 137);
            this.lblUploadImg.Name = "lblUploadImg";
            this.lblUploadImg.Size = new System.Drawing.Size(122, 22);
            this.lblUploadImg.TabIndex = 0;
            this.lblUploadImg.Text = "upload image";
            this.lblUploadImg.Click += new System.EventHandler(this.LblUploadImg_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearchP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPatientInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUploadImg;
        private System.Windows.Forms.PictureBox pctUpload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picbSearchP;
        private System.Windows.Forms.TextBox txtSearchP;
        private System.Windows.Forms.DataGridView dtPatientInfo;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Panel pnlMove3;
        private System.Windows.Forms.Panel pnlMove2;
        private System.Windows.Forms.Panel pnlMove1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}