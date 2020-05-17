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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.dgvPatientHistory = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuSPatientPro = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).BeginInit();
            this.contextMenuSPatientPro.SuspendLayout();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.name,
            this.visiting_date,
            this.p_filename});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientHistory.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.dgvPatientHistory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvPatientHistory_CellMouseClick);
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
            // p_filename
            // 
            this.p_filename.DataPropertyName = "p_filename";
            this.p_filename.HeaderText = "Prescription";
            this.p_filename.Name = "p_filename";
            this.p_filename.ReadOnly = true;
            // 
            // contextMenuSPatientPro
            // 
            this.contextMenuSPatientPro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuSPatientPro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuSPatientPro.Name = "contextMenuSPatientPro";
            this.contextMenuSPatientPro.Size = new System.Drawing.Size(211, 80);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.DownloadToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
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
            this.contextMenuSPatientPro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        internal System.Windows.Forms.DataGridView dgvPatientHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiting_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_filename;
        private System.Windows.Forms.ContextMenuStrip contextMenuSPatientPro;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
