namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDoctorCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.btnSingUp = new System.Windows.Forms.Button();
            this.txtMobileNum = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.lblDoctorCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbUserType);
            this.panel1.Controls.Add(this.chkPassword);
            this.panel1.Controls.Add(this.btnSingUp);
            this.panel1.Controls.Add(this.txtMobileNum);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 498);
            this.panel1.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Dermatologist",
            "Opthalmologist",
            "Ear, Nose and Throat"});
            this.cmbCategory.Location = new System.Drawing.Point(223, 326);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(254, 33);
            this.cmbCategory.TabIndex = 15;
            // 
            // lblDoctorCategory
            // 
            this.lblDoctorCategory.AutoSize = true;
            this.lblDoctorCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorCategory.Location = new System.Drawing.Point(50, 329);
            this.lblDoctorCategory.Name = "lblDoctorCategory";
            this.lblDoctorCategory.Size = new System.Drawing.Size(92, 25);
            this.lblDoctorCategory.TabIndex = 14;
            this.lblDoctorCategory.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "User Type";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist",
            "Pathologist"});
            this.cmbUserType.Location = new System.Drawing.Point(223, 265);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(254, 33);
            this.cmbUserType.TabIndex = 12;
            this.cmbUserType.SelectedIndexChanged += new System.EventHandler(this.CmbUserType_SelectedIndexChanged);
            // 
            // chkPassword
            // 
            this.chkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkPassword.Image = ((System.Drawing.Image)(resources.GetObject("chkPassword.Image")));
            this.chkPassword.Location = new System.Drawing.Point(483, 140);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(54, 22);
            this.chkPassword.TabIndex = 11;
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.ChkPassword_CheckedChanged);
            this.chkPassword.CheckStateChanged += new System.EventHandler(this.ChkPassword_CheckedChanged);
            // 
            // btnSingUp
            // 
            this.btnSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingUp.Location = new System.Drawing.Point(251, 404);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(118, 34);
            this.btnSingUp.TabIndex = 10;
            this.btnSingUp.Text = "Sign Up";
            this.btnSingUp.UseVisualStyleBackColor = true;
            this.btnSingUp.Click += new System.EventHandler(this.BtnSingUp_Click);
            // 
            // txtMobileNum
            // 
            this.txtMobileNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNum.Location = new System.Drawing.Point(223, 202);
            this.txtMobileNum.Name = "txtMobileNum";
            this.txtMobileNum.Size = new System.Drawing.Size(254, 30);
            this.txtMobileNum.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(223, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(223, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(254, 30);
            this.txtUserName.TabIndex = 0;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 554);
            this.Controls.Add(this.panel1);
            this.Name = "FormSignUp";
            this.Text = "FormSinUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignUp_FormClosed);
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMobileNum;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSingUp;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDoctorCategory;
    }
}