namespace WindowsFormsAppPocketDoctorProject
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
            this.pcbRefresh = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.dgvPatientPro = new System.Windows.Forms.DataGridView();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreatePatient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientPro)).BeginInit();
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
            this.panel1.Controls.Add(this.pcbRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvPatientPro);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCreatePatient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 694);
            this.panel1.TabIndex = 1;
            // 
            // pcbRefresh
            // 
            this.pcbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("pcbRefresh.Image")));
            this.pcbRefresh.Location = new System.Drawing.Point(1064, 12);
            this.pcbRefresh.Name = "pcbRefresh";
            this.pcbRefresh.Size = new System.Drawing.Size(73, 50);
            this.pcbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRefresh.TabIndex = 20;
            this.pcbRefresh.TabStop = false;
            this.pcbRefresh.Click += new System.EventHandler(this.PcbRefresh_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(883, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(254, 57);
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
            this.lblDate.Location = new System.Drawing.Point(68, 14);
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
            this.lbTime.Location = new System.Drawing.Point(130, 45);
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
            this.dgvPatientPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.pid,
            this.name,
            this.age,
            this.gender,
            this.mobilenumber});
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
            this.dgvPatientPro.Location = new System.Drawing.Point(1, 178);
            this.dgvPatientPro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPatientPro.Name = "dgvPatientPro";
            this.dgvPatientPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientPro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatientPro.RowHeadersVisible = false;
            this.dgvPatientPro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientPro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatientPro.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPatientPro.RowTemplate.Height = 40;
            this.dgvPatientPro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvPatientPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientPro.Size = new System.Drawing.Size(1151, 405);
            this.dgvPatientPro.TabIndex = 15;
            this.dgvPatientPro.Tag = "";
            this.dgvPatientPro.VirtualMode = true;
            // 
            // pid
            // 
            this.pid.DataPropertyName = "pid";
            this.pid.HeaderText = "Patient Id";
            this.pid.Name = "pid";
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
            // mobilenumber
            // 
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.HeaderText = "Mobile Number";
            this.mobilenumber.Name = "mobilenumber";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.picbSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(14, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 69);
            this.panel3.TabIndex = 12;
            // 
            // picbSearch
            // 
            this.picbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbSearch.Image = ((System.Drawing.Image)(resources.GetObject("picbSearch.Image")));
            this.picbSearch.Location = new System.Drawing.Point(335, 19);
            this.picbSearch.Name = "picbSearch";
            this.picbSearch.Size = new System.Drawing.Size(50, 34);
            this.picbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbSearch.TabIndex = 11;
            this.picbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(25, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 30);
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
            this.btnUpdate.Location = new System.Drawing.Point(612, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(236, 57);
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
            this.btnCreatePatient.Location = new System.Drawing.Point(325, 104);
            this.btnCreatePatient.Name = "btnCreatePatient";
            this.btnCreatePatient.Size = new System.Drawing.Size(249, 57);
            this.btnCreatePatient.TabIndex = 4;
            this.btnCreatePatient.Text = "New Patient Profile";
            this.btnCreatePatient.UseVisualStyleBackColor = true;
            this.btnCreatePatient.Click += new System.EventHandler(this.BtnCreatePatient_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(67, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Appointment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timerR
            // 
            this.timerR.Tick += new System.EventHandler(this.TimerR_Tick);
            // 
            // FormReceptonist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 722);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReceptonist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceptonist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceptonist_FormClosed);
            this.Load += new System.EventHandler(this.FormReceptonist_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRefresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientPro)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPatientPro;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pcbRefresh;
    }
}