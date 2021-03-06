﻿namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormReceptonist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceptonist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShowAppointment = new System.Windows.Forms.Button();
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.dgvPatientPro = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMSReceptionist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientPro)).BeginInit();
            this.CMSReceptionist.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnShowReport);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnShowAppointment);
            this.panel1.Controls.Add(this.pcbRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvPatientPro);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCreatePatient);
            this.panel1.Controls.Add(this.btnAppointment);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 727);
            this.panel1.TabIndex = 1;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowReport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowReport.FlatAppearance.BorderSize = 0;
            this.btnShowReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.ForeColor = System.Drawing.SystemColors.Info;
            this.btnShowReport.Location = new System.Drawing.Point(634, 88);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(136, 61);
            this.btnShowReport.TabIndex = 24;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 39);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnShowAppointment
            // 
            this.btnShowAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowAppointment.FlatAppearance.BorderSize = 0;
            this.btnShowAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnShowAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAppointment.ForeColor = System.Drawing.SystemColors.Info;
            this.btnShowAppointment.Location = new System.Drawing.Point(424, 92);
            this.btnShowAppointment.Name = "btnShowAppointment";
            this.btnShowAppointment.Size = new System.Drawing.Size(160, 57);
            this.btnShowAppointment.TabIndex = 22;
            this.btnShowAppointment.Text = "Show Appointments";
            this.btnShowAppointment.UseVisualStyleBackColor = true;
            this.btnShowAppointment.Click += new System.EventHandler(this.BtnShowAppointment_Click);
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcbRefresh.Image")));
            this.pcbRefresh.Location = new System.Drawing.Point(1115, 9);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(56, 51);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbRefresh.TabIndex = 20;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.PcbRefresh_Click);
            this.pcbRefresh.MouseLeave += new System.EventHandler(this.PcbRefresh_MouseLeave);
            this.pcbRefresh.MouseHover += new System.EventHandler(this.PcbRefresh_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(1000, 84);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 73);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Profile";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Location = new System.Drawing.Point(808, 618);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 73);
            this.panel2.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDate.Location = new System.Drawing.Point(26, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 23);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Time";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbTime.Location = new System.Drawing.Point(147, 37);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 23);
            this.lbTime.TabIndex = 16;
            this.lbTime.Text = "Time";
            // 
            // dgvPatientPro
            // 
            this.dgvPatientPro.AllowUserToAddRows = false;
            this.dgvPatientPro.AllowUserToDeleteRows = false;
            this.dgvPatientPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientPro.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPatientPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPatientPro.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPatientPro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.name,
            this.age,
            this.gender,
            this.bloodgroup,
            this.mobilenumber});
            this.dgvPatientPro.ContextMenuStrip = this.CMSReceptionist;
            this.dgvPatientPro.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientPro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientPro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvPatientPro.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatientPro.Location = new System.Drawing.Point(4, 168);
            this.dgvPatientPro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPatientPro.MultiSelect = false;
            this.dgvPatientPro.Name = "dgvPatientPro";
            this.dgvPatientPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientPro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatientPro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientPro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientPro.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPatientPro.RowTemplate.Height = 40;
            this.dgvPatientPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientPro.Size = new System.Drawing.Size(1170, 431);
            this.dgvPatientPro.TabIndex = 15;
            this.dgvPatientPro.Tag = "";
            this.dgvPatientPro.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPatientPro_CellMouseClick);
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "Patient Id";
            this.p_id.Name = "p_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Patient Name";
            this.name.Name = "name";
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // bloodgroup
            // 
            this.bloodgroup.DataPropertyName = "bloodgroup";
            this.bloodgroup.HeaderText = "Blood Group";
            this.bloodgroup.Name = "bloodgroup";
            // 
            // mobilenumber
            // 
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.HeaderText = "Mobile Number";
            this.mobilenumber.Name = "mobilenumber";
            // 
            // CMSReceptionist
            // 
            this.CMSReceptionist.BackColor = System.Drawing.Color.White;
            this.CMSReceptionist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMSReceptionist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPatientToolStripMenuItem,
            this.deletePatientToolStripMenuItem,
            this.updatePatientToolStripMenuItem,
            this.addPatientToolStripMenuItem,
            this.newAppointmentToolStripMenuItem});
            this.CMSReceptionist.Name = "CMSReceptionist";
            this.CMSReceptionist.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMSReceptionist.Size = new System.Drawing.Size(205, 134);
            // 
            // refreshPatientToolStripMenuItem
            // 
            this.refreshPatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshPatientToolStripMenuItem.Image")));
            this.refreshPatientToolStripMenuItem.Name = "refreshPatientToolStripMenuItem";
            this.refreshPatientToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.refreshPatientToolStripMenuItem.Text = "Refresh";
            this.refreshPatientToolStripMenuItem.Click += new System.EventHandler(this.MenuSTripRefresh_Click);
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePatientToolStripMenuItem.Image")));
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.deletePatientToolStripMenuItem.Text = "Delete";
            this.deletePatientToolStripMenuItem.Click += new System.EventHandler(this.MenuStripDelete_Click);
            // 
            // updatePatientToolStripMenuItem
            // 
            this.updatePatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatePatientToolStripMenuItem.Image")));
            this.updatePatientToolStripMenuItem.Name = "updatePatientToolStripMenuItem";
            this.updatePatientToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.updatePatientToolStripMenuItem.Text = "Update";
            this.updatePatientToolStripMenuItem.Click += new System.EventHandler(this.MenuStripUpdate_Click);
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPatientToolStripMenuItem.Image")));
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.AddPatientToolStripMenuItem_Click);
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.newAppointmentToolStripMenuItem.Text = "New Appointment";
            this.newAppointmentToolStripMenuItem.Click += new System.EventHandler(this.NewAppointmentToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picbSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(11, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 69);
            this.panel3.TabIndex = 12;
            // 
            // picbSearch
            // 
            this.picbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbSearch.Image = ((System.Drawing.Image)(resources.GetObject("picbSearch.Image")));
            this.picbSearch.Location = new System.Drawing.Point(325, 19);
            this.picbSearch.Name = "picbSearch";
            this.picbSearch.Size = new System.Drawing.Size(50, 34);
            this.picbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbSearch.TabIndex = 11;
            this.picbSearch.TabStop = false;
            this.picbSearch.Click += new System.EventHandler(this.PicbSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(15, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 34);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(826, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 65);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCreatePatient
            // 
            this.btnCreatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCreatePatient.FlatAppearance.BorderSize = 0;
            this.btnCreatePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCreatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePatient.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCreatePatient.Location = new System.Drawing.Point(236, 96);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(150, 65);
            this.btnCreatePatient.TabIndex = 4;
            this.btnCreatePatient.Text = "New Patient Profile";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.BtnCreatePatient_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAppointment.Location = new System.Drawing.Point(35, 100);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(143, 57);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "New Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.BtnAppointment_Click);
            // 
            // timerR
            // 
            this.timerR.Tick += new System.EventHandler(this.TimerR_Tick);
            // 
            // FormReceptonist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 722);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormReceptonist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptonist";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptonist_FormClosed);
            this.Load += new System.EventHandler(this.FormReceptonist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientPro)).EndInit();
            this.CMSReceptionist.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreatePatient;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pcbRefresh;
        internal System.Windows.Forms.DataGridView dgvPatientPro;
        private System.Windows.Forms.Button btnShowAppointment;
        private System.Windows.Forms.ContextMenuStrip CMSReceptionist;
        private System.Windows.Forms.ToolStripMenuItem refreshPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnShowReport;
    }
}