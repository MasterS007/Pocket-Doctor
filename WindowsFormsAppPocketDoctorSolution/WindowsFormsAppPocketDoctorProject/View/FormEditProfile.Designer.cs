namespace WindowsFormsAppPocketDoctorProject.View
{
    partial class FormEditProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtEdubackground = new System.Windows.Forms.TextBox();
            this.lblEdubackground = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtEdubackground);
            this.panel1.Controls.Add(this.lblEdubackground);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.lblMobile);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 493);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(319, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(319, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 34);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(24, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(319, 211);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(278, 34);
            this.txtMobile.TabIndex = 5;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(24, 214);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(180, 29);
            this.lblMobile.TabIndex = 4;
            this.lblMobile.Text = "Mobile Number";
            // 
            // txtEdubackground
            // 
            this.txtEdubackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdubackground.Location = new System.Drawing.Point(319, 305);
            this.txtEdubackground.Name = "txtEdubackground";
            this.txtEdubackground.Size = new System.Drawing.Size(278, 34);
            this.txtEdubackground.TabIndex = 7;
            // 
            // lblEdubackground
            // 
            this.lblEdubackground.AutoSize = true;
            this.lblEdubackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdubackground.Location = new System.Drawing.Point(24, 310);
            this.lblEdubackground.Name = "lblEdubackground";
            this.lblEdubackground.Size = new System.Drawing.Size(274, 29);
            this.lblEdubackground.TabIndex = 6;
            this.lblEdubackground.Text = "Educational Background";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(227, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 517);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormEditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditProfile";
            this.Load += new System.EventHandler(this.FormEditProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEdubackground;
        private System.Windows.Forms.Label lblEdubackground;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSave;
    }
}