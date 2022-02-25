namespace WinUSBAuthentication
{
    partial class FrmCreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateAcc));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.lregYubiKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMoveFormLogin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lCAccBack = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblKeycardTitle = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbConfPassword = new System.Windows.Forms.TextBox();
            this.cbshowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMoveFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Location = new System.Drawing.Point(67, 406);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 44);
            this.panel2.TabIndex = 27;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(4, 4);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.MaxLength = 512;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(339, 35);
            this.tbPassword.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.tbusername);
            this.panel1.Location = new System.Drawing.Point(67, 297);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 44);
            this.panel1.TabIndex = 26;
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(4, 4);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4);
            this.tbusername.MaxLength = 24;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(339, 35);
            this.tbusername.TabIndex = 10;
            // 
            // lregYubiKey
            // 
            this.lregYubiKey.AutoSize = true;
            this.lregYubiKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lregYubiKey.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregYubiKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lregYubiKey.Location = new System.Drawing.Point(123, 751);
            this.lregYubiKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lregYubiKey.Name = "lregYubiKey";
            this.lregYubiKey.Size = new System.Drawing.Size(199, 25);
            this.lregYubiKey.TabIndex = 25;
            this.lregYubiKey.Text = "register new YubiKey";
            this.lregYubiKey.Click += new System.EventHandler(this.lregYubiKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(61, 377);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password";
            // 
            // panelMoveFormLogin
            // 
            this.panelMoveFormLogin.Controls.Add(this.lblClose);
            this.panelMoveFormLogin.Location = new System.Drawing.Point(-1, -1);
            this.panelMoveFormLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelMoveFormLogin.Name = "panelMoveFormLogin";
            this.panelMoveFormLogin.Size = new System.Drawing.Size(484, 54);
            this.panelMoveFormLogin.TabIndex = 23;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblClose.Location = new System.Drawing.Point(436, 11);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lCAccBack
            // 
            this.lCAccBack.AutoSize = true;
            this.lCAccBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCAccBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lCAccBack.Location = new System.Drawing.Point(156, 705);
            this.lCAccBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCAccBack.Name = "lCAccBack";
            this.lCAccBack.Size = new System.Drawing.Size(136, 28);
            this.lCAccBack.TabIndex = 22;
            this.lCAccBack.Text = "back to login";
            this.lCAccBack.Click += new System.EventHandler(this.lCAccBack_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(67, 48);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(347, 92);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 21;
            this.pbLogo.TabStop = false;
            // 
            // lblKeycardTitle
            // 
            this.lblKeycardTitle.AutoSize = true;
            this.lblKeycardTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeycardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblKeycardTitle.Location = new System.Drawing.Point(61, 267);
            this.lblKeycardTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeycardTitle.Name = "lblKeycardTitle";
            this.lblKeycardTitle.Size = new System.Drawing.Size(106, 28);
            this.lblKeycardTitle.TabIndex = 20;
            this.lblKeycardTitle.Text = "Username";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(55, 177);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(310, 54);
            this.lblLoginTitle.TabIndex = 19;
            this.lblLoginTitle.Text = "Create Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(65, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Confirm Password";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel3.Controls.Add(this.tbConfPassword);
            this.panel3.Location = new System.Drawing.Point(65, 517);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 44);
            this.panel3.TabIndex = 32;
            // 
            // tbConfPassword
            // 
            this.tbConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfPassword.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfPassword.Location = new System.Drawing.Point(4, 4);
            this.tbConfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfPassword.MaxLength = 512;
            this.tbConfPassword.Name = "tbConfPassword";
            this.tbConfPassword.PasswordChar = '*';
            this.tbConfPassword.Size = new System.Drawing.Size(339, 35);
            this.tbConfPassword.TabIndex = 10;
            // 
            // cbshowPassword
            // 
            this.cbshowPassword.AutoSize = true;
            this.cbshowPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbshowPassword.Location = new System.Drawing.Point(65, 569);
            this.cbshowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.cbshowPassword.Name = "cbshowPassword";
            this.cbshowPassword.Size = new System.Drawing.Size(162, 27);
            this.cbshowPassword.TabIndex = 33;
            this.cbshowPassword.Text = "Show Passwords";
            this.cbshowPassword.UseVisualStyleBackColor = true;
            this.cbshowPassword.CheckedChanged += new System.EventHandler(this.cbshowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(67, 615);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(348, 69);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "Create New Account";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 818);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbshowPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lregYubiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMoveFormLogin);
            this.Controls.Add(this.lCAccBack);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblKeycardTitle);
            this.Controls.Add(this.lblLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCreateAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FemSignUp";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMoveFormLogin.ResumeLayout(false);
            this.panelMoveFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label lregYubiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMoveFormLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lCAccBack;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblKeycardTitle;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbConfPassword;
        private System.Windows.Forms.CheckBox cbshowPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}