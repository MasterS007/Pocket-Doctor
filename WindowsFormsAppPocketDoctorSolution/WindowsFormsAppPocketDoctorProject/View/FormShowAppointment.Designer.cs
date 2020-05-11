namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormShowAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimeChoose = new MetroFramework.Controls.MetroDateTime();
            this.btnCancelApp = new System.Windows.Forms.Button();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.appt_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.dateTimeChoose);
            this.panel1.Controls.Add(this.btnCancelApp);
            this.panel1.Controls.Add(this.dgvAppointment);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 503);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(778, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(620, 52);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(246, 33);
            this.cmbDoctor.TabIndex = 3;
            // 
            // dateTimeChoose
            // 
            this.dateTimeChoose.Location = new System.Drawing.Point(620, 16);
            this.dateTimeChoose.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTimeChoose.Name = "dateTimeChoose";
            this.dateTimeChoose.Size = new System.Drawing.Size(246, 30);
            this.dateTimeChoose.TabIndex = 2;
            // 
            // btnCancelApp
            // 
            this.btnCancelApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelApp.Location = new System.Drawing.Point(633, 453);
            this.btnCancelApp.Name = "btnCancelApp";
            this.btnCancelApp.Size = new System.Drawing.Size(236, 32);
            this.btnCancelApp.TabIndex = 1;
            this.btnCancelApp.Text = "Cancel Appointment";
            this.btnCancelApp.UseVisualStyleBackColor = true;
            this.btnCancelApp.Click += new System.EventHandler(this.BtnCancelApp_Click);
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AllowUserToAddRows = false;
            this.dgvAppointment.AllowUserToDeleteRows = false;
            this.dgvAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointment.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appt_id,
            this.p_id,
            this.name,
            this.mobilenumber,
            this.visiting_date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointment.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAppointment.Location = new System.Drawing.Point(3, 123);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.ReadOnly = true;
            this.dgvAppointment.RowTemplate.Height = 24;
            this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointment.Size = new System.Drawing.Size(869, 309);
            this.dgvAppointment.TabIndex = 0;
            // 
            // appt_id
            // 
            this.appt_id.DataPropertyName = "appt_id";
            this.appt_id.HeaderText = "Appointment ID";
            this.appt_id.Name = "appt_id";
            this.appt_id.ReadOnly = true;
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
            // mobilenumber
            // 
            this.mobilenumber.DataPropertyName = "mobilenumber";
            this.mobilenumber.HeaderText = "Mobile Number";
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.ReadOnly = true;
            // 
            // visiting_date
            // 
            this.visiting_date.DataPropertyName = "visiting_date";
            this.visiting_date.HeaderText = "Appointment Date";
            this.visiting_date.Name = "visiting_date";
            this.visiting_date.ReadOnly = true;
            // 
            // FormShowAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 527);
            this.Controls.Add(this.panel1);
            this.Name = "FormShowAppointment";
            this.Text = "FormShowAppointment";
            this.Load += new System.EventHandler(this.FormShowAppointment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Button btnCancelApp;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private MetroFramework.Controls.MetroDateTime dateTimeChoose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn appt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn visiting_date;
    }
}