namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class UserControlPatientHis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.dgvPatientHistory = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHome.Controls.Add(this.dgvPatientHistory);
            this.pnlHome.Location = new System.Drawing.Point(3, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(948, 482);
            this.pnlHome.TabIndex = 0;
            // 
            // dgvPatientHistory
            // 
            this.dgvPatientHistory.AllowUserToAddRows = false;
            this.dgvPatientHistory.AllowUserToDeleteRows = false;
            this.dgvPatientHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatientHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.name,
            this.visiting_date,
            this.repname,
            this.p_filename});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientHistory.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPatientHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvPatientHistory.MultiSelect = false;
            this.dgvPatientHistory.Name = "dgvPatientHistory";
            this.dgvPatientHistory.ReadOnly = true;
            this.dgvPatientHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPatientHistory.RowTemplate.Height = 24;
            this.dgvPatientHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPatientHistory.Size = new System.Drawing.Size(945, 479);
            this.dgvPatientHistory.TabIndex = 0;
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
            // visiting_date
            // 
            this.visiting_date.DataPropertyName = "visiting_date";
            this.visiting_date.HeaderText = "Appointment Date";
            this.visiting_date.Name = "visiting_date";
            this.visiting_date.ReadOnly = true;
            // 
            // repname
            // 
            this.repname.DataPropertyName = "repname";
            this.repname.HeaderText = "Report";
            this.repname.Name = "repname";
            this.repname.ReadOnly = true;
            // 
            // p_filename
            // 
            this.p_filename.DataPropertyName = "p_filename";
            this.p_filename.HeaderText = "Prescription";
            this.p_filename.Name = "p_filename";
            this.p_filename.ReadOnly = true;
            // 
            // UserControlPatientHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlHome);
            this.Location = new System.Drawing.Point(4, 130);
            this.Name = "UserControlPatientHis";
            this.Size = new System.Drawing.Size(954, 488);
            this.Load += new System.EventHandler(this.UserControlPatientHis_Load);
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiting_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn repname;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_filename;
        internal System.Windows.Forms.DataGridView dgvPatientHistory;
    }
}
