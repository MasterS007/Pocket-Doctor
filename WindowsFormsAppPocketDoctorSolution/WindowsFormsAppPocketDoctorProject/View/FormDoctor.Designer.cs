﻿namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDoctor = new System.Windows.Forms.Panel();
            this.lblApList = new System.Windows.Forms.Label();
            this.btnDownlaod = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbSearchP = new System.Windows.Forms.PictureBox();
            this.txtSearchP = new System.Windows.Forms.TextBox();
            this.dgvPatientInfor = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMove2 = new System.Windows.Forms.Panel();
            this.pnlMove1 = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pctUpload = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblUploadImg = new System.Windows.Forms.Label();
            this.timerD = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripDOc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolConStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDoctor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newPrescriptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDoctorProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatienProfileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDoctor.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearchP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).BeginInit();
            this.contextMenuStripDOc.SuspendLayout();
            this.menuStripDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.pnlDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDoctor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDoctor.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlDoctor.Controls.Add(this.lblApList);
            this.pnlDoctor.Controls.Add(this.btnDownlaod);
            this.pnlDoctor.Controls.Add(this.btnUpload);
            this.pnlDoctor.Controls.Add(this.panel4);
            this.pnlDoctor.Controls.Add(this.panel3);
            this.pnlDoctor.Controls.Add(this.dgvPatientInfor);
            this.pnlDoctor.Location = new System.Drawing.Point(231, 31);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(964, 732);
            this.pnlDoctor.TabIndex = 0;
            // 
            // lblApList
            // 
            this.lblApList.AutoSize = true;
            this.lblApList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApList.ForeColor = System.Drawing.Color.White;
            this.lblApList.Location = new System.Drawing.Point(306, 123);
            this.lblApList.Name = "lblApList";
            this.lblApList.Size = new System.Drawing.Size(281, 29);
            this.lblApList.TabIndex = 18;
            this.lblApList.Text = "Today\'s Appointment List";
            // 
            // btnDownlaod
            // 
            this.btnDownlaod.BackColor = System.Drawing.Color.White;
            this.btnDownlaod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownlaod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownlaod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownlaod.Location = new System.Drawing.Point(27, 687);
            this.btnDownlaod.Name = "btnDownlaod";
            this.btnDownlaod.Size = new System.Drawing.Size(208, 38);
            this.btnDownlaod.TabIndex = 17;
            this.btnDownlaod.Text = " Download Prescription";
            this.btnDownlaod.UseVisualStyleBackColor = false;
            this.btnDownlaod.Click += new System.EventHandler(this.BtnDownlaod_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(27, 645);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(208, 38);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "Upload Prescription";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDate);
            this.panel4.Controls.Add(this.lbTime);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(617, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 70);
            this.panel4.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 23);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Time";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(119, 34);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 23);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picbSearchP);
            this.panel3.Controls.Add(this.txtSearchP);
            this.panel3.Location = new System.Drawing.Point(475, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 62);
            this.panel3.TabIndex = 11;
            // 
            // picbSearchP
            // 
            this.picbSearchP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbSearchP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbSearchP.Image = ((System.Drawing.Image)(resources.GetObject("picbSearchP.Image")));
            this.picbSearchP.Location = new System.Drawing.Point(405, 12);
            this.picbSearchP.Name = "picbSearchP";
            this.picbSearchP.Size = new System.Drawing.Size(50, 34);
            this.picbSearchP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbSearchP.TabIndex = 11;
            this.picbSearchP.TabStop = false;
            // 
            // txtSearchP
            // 
            this.txtSearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchP.Location = new System.Drawing.Point(44, 12);
            this.txtSearchP.Name = "txtSearchP";
            this.txtSearchP.Size = new System.Drawing.Size(355, 34);
            this.txtSearchP.TabIndex = 10;
            this.txtSearchP.TextChanged += new System.EventHandler(this.TxtSearchP_TextChanged);
            // 
            // dgvPatientInfor
            // 
            this.dgvPatientInfor.AllowUserToAddRows = false;
            this.dgvPatientInfor.AllowUserToDeleteRows = false;
            this.dgvPatientInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientInfor.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientInfor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientInfor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPatientInfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientInfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.name,
            this.age,
            this.gender,
            this.visiting_date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientInfor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientInfor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvPatientInfor.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatientInfor.Location = new System.Drawing.Point(4, 171);
            this.dgvPatientInfor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPatientInfor.MultiSelect = false;
            this.dgvPatientInfor.Name = "dgvPatientInfor";
            this.dgvPatientInfor.ReadOnly = true;
            this.dgvPatientInfor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientInfor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatientInfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientInfor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientInfor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPatientInfor.RowTemplate.Height = 40;
            this.dgvPatientInfor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPatientInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientInfor.Size = new System.Drawing.Size(956, 437);
            this.dgvPatientInfor.TabIndex = 9;
            this.dgvPatientInfor.Tag = "";
            this.dgvPatientInfor.VirtualMode = true;
            this.dgvPatientInfor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPatientInfor_CellMouseClick);
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "Patient Id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Patient Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // visiting_date
            // 
            this.visiting_date.DataPropertyName = "visiting_date";
            this.visiting_date.HeaderText = "Visiting Date";
            this.visiting_date.Name = "visiting_date";
            this.visiting_date.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlMove2);
            this.panel2.Controls.Add(this.pnlMove1);
            this.panel2.Controls.Add(this.pnlMove);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnPatient);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pctUpload);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.lblUploadImg);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 732);
            this.panel2.TabIndex = 1;
            // 
            // pnlMove2
            // 
            this.pnlMove2.AutoScroll = true;
            this.pnlMove2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMove2.Location = new System.Drawing.Point(5, 537);
            this.pnlMove2.Name = "pnlMove2";
            this.pnlMove2.Size = new System.Drawing.Size(20, 71);
            this.pnlMove2.TabIndex = 14;
            // 
            // pnlMove1
            // 
            this.pnlMove1.AutoScroll = true;
            this.pnlMove1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMove1.Location = new System.Drawing.Point(5, 399);
            this.pnlMove1.Name = "pnlMove1";
            this.pnlMove1.Size = new System.Drawing.Size(20, 69);
            this.pnlMove1.TabIndex = 13;
            // 
            // pnlMove
            // 
            this.pnlMove.AutoScroll = true;
            this.pnlMove.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMove.Location = new System.Drawing.Point(5, 251);
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
            this.btnHome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Location = new System.Drawing.Point(29, 251);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 71);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPatient.Location = new System.Drawing.Point(29, 537);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(137, 71);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Patient Profile";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.BtnPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(40, 686);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(111, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // pctUpload
            // 
            this.pctUpload.Image = ((System.Drawing.Image)(resources.GetObject("pctUpload.Image")));
            this.pctUpload.Location = new System.Drawing.Point(5, 3);
            this.pctUpload.Name = "pctUpload";
            this.pctUpload.Size = new System.Drawing.Size(205, 134);
            this.pctUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUpload.TabIndex = 0;
            this.pctUpload.TabStop = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnProfile.Location = new System.Drawing.Point(29, 399);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(130, 69);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // lblUploadImg
            // 
            this.lblUploadImg.AutoSize = true;
            this.lblUploadImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImg.ForeColor = System.Drawing.Color.Coral;
            this.lblUploadImg.Location = new System.Drawing.Point(29, 140);
            this.lblUploadImg.Name = "lblUploadImg";
            this.lblUploadImg.Size = new System.Drawing.Size(122, 22);
            this.lblUploadImg.TabIndex = 0;
            this.lblUploadImg.Text = "upload image";
            this.lblUploadImg.Click += new System.EventHandler(this.LblUploadImg_Click);
            // 
            // timerD
            // 
            this.timerD.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStripDOc
            // 
            this.contextMenuStripDOc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDOc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolConStripMenuItem,
            this.refreshConToolStripMenuItem});
            this.contextMenuStripDOc.Name = "contextMenuStripDOc";
            this.contextMenuStripDOc.Size = new System.Drawing.Size(128, 52);
            // 
            // newToolConStripMenuItem
            // 
            this.newToolConStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionToolStripMenuItem1});
            this.newToolConStripMenuItem.Name = "newToolConStripMenuItem";
            this.newToolConStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.newToolConStripMenuItem.Text = "New";
            // 
            // prescriptionToolStripMenuItem1
            // 
            this.prescriptionToolStripMenuItem1.Name = "prescriptionToolStripMenuItem1";
            this.prescriptionToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.prescriptionToolStripMenuItem1.Text = "Prescription";
            this.prescriptionToolStripMenuItem1.Click += new System.EventHandler(this.PrescriptionToolStripMenuItem1_Click);
            // 
            // refreshConToolStripMenuItem
            // 
            this.refreshConToolStripMenuItem.Name = "refreshConToolStripMenuItem";
            this.refreshConToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshConToolStripMenuItem.Text = "Refresh";
            this.refreshConToolStripMenuItem.Click += new System.EventHandler(this.RefreshConToolStripMenuItem_Click);
            // 
            // previousPrescriptionToolStripMenuItem
            // 
            this.previousPrescriptionToolStripMenuItem.Name = "previousPrescriptionToolStripMenuItem";
            this.previousPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.previousPrescriptionToolStripMenuItem.Text = "Previous Prescription";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousPrescriptionToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prescriptionToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // menuStripDoctor
            // 
            this.menuStripDoctor.BackColor = System.Drawing.Color.White;
            this.menuStripDoctor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripDoctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStripDoctor.Location = new System.Drawing.Point(0, 0);
            this.menuStripDoctor.Name = "menuStripDoctor";
            this.menuStripDoctor.Size = new System.Drawing.Size(1203, 28);
            this.menuStripDoctor.TabIndex = 2;
            this.menuStripDoctor.Text = "menuStripDoctor";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPrescriptionMenu});
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // newPrescriptionMenu
            // 
            this.newPrescriptionMenu.Name = "newPrescriptionMenu";
            this.newPrescriptionMenu.Size = new System.Drawing.Size(162, 26);
            this.newPrescriptionMenu.Text = "Prescription";
            this.newPrescriptionMenu.Click += new System.EventHandler(this.NewPrescriptionMenu_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDoctorProfileMenu});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editDoctorProfileMenu
            // 
            this.editDoctorProfileMenu.Name = "editDoctorProfileMenu";
            this.editDoctorProfileMenu.Size = new System.Drawing.Size(216, 26);
            this.editDoctorProfileMenu.Text = "Profile";
            this.editDoctorProfileMenu.Click += new System.EventHandler(this.EditDoctorProfileMenu_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDoctorProfileMenu,
            this.viewPatienProfileMenu,
            this.viewHomeMenu});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewDoctorProfileMenu
            // 
            this.viewDoctorProfileMenu.Name = "viewDoctorProfileMenu";
            this.viewDoctorProfileMenu.Size = new System.Drawing.Size(216, 26);
            this.viewDoctorProfileMenu.Text = "Profile";
            this.viewDoctorProfileMenu.Click += new System.EventHandler(this.ViewDoctorProfileMenu_Click);
            // 
            // viewPatienProfileMenu
            // 
            this.viewPatienProfileMenu.Name = "viewPatienProfileMenu";
            this.viewPatienProfileMenu.Size = new System.Drawing.Size(216, 26);
            this.viewPatienProfileMenu.Text = "Patient Profile";
            this.viewPatienProfileMenu.Click += new System.EventHandler(this.ViewPatienProfileMenu_Click);
            // 
            // viewHomeMenu
            // 
            this.viewHomeMenu.Name = "viewHomeMenu";
            this.viewHomeMenu.Size = new System.Drawing.Size(216, 26);
            this.viewHomeMenu.Text = "Home";
            this.viewHomeMenu.Click += new System.EventHandler(this.ViewHomeMenu_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 775);
            this.Controls.Add(this.menuStripDoctor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDoctor);
            this.MainMenuStrip = this.menuStripDoctor;
            this.MaximizeBox = false;
            this.Name = "FormDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearchP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientInfor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpload)).EndInit();
            this.contextMenuStripDOc.ResumeLayout(false);
            this.menuStripDoctor.ResumeLayout(false);
            this.menuStripDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUploadImg;
        private System.Windows.Forms.PictureBox pctUpload;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picbSearchP;
        private System.Windows.Forms.TextBox txtSearchP;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Panel pnlMove2;
        private System.Windows.Forms.Panel pnlMove1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDOc;
        private System.Windows.Forms.ToolStripMenuItem newToolConStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshConToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPatientInfor;
        private System.Windows.Forms.ToolStripMenuItem previousPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripDoctor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newPrescriptionMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDoctorProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewPatienProfileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHomeMenu;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownlaod;
        private System.Windows.Forms.Label lblApList;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiting_date;
    }
}