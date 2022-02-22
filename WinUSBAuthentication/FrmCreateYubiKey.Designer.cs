namespace WinUSBAuthentication
{
    partial class FrmCreateYubiKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateYubiKey));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lYKeyBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMoveFormLogin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lYkeybackr = new System.Windows.Forms.Label();
            this.cbUSB = new System.Windows.Forms.ComboBox();
            this.lblKeycardTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbshowPassword = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbConfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelMoveFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Location = new System.Drawing.Point(55, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 36);
            this.panel2.TabIndex = 27;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(5, 3);
            this.tbPassword.MaxLength = 24;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(254, 28);
            this.tbPassword.TabIndex = 10;
            // 
            // lYKeyBack
            // 
            this.lYKeyBack.AutoSize = true;
            this.lYKeyBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lYKeyBack.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYKeyBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lYKeyBack.Location = new System.Drawing.Point(125, 573);
            this.lYKeyBack.Name = "lYKeyBack";
            this.lYKeyBack.Size = new System.Drawing.Size(99, 20);
            this.lYKeyBack.TabIndex = 25;
            this.lYKeyBack.Text = "back to login";
            this.lYKeyBack.Click += new System.EventHandler(this.lYKeyBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(51, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Username";
            // 
            // panelMoveFormLogin
            // 
            this.panelMoveFormLogin.Controls.Add(this.lblClose);
            this.panelMoveFormLogin.Location = new System.Drawing.Point(-1, 0);
            this.panelMoveFormLogin.Name = "panelMoveFormLogin";
            this.panelMoveFormLogin.Size = new System.Drawing.Size(363, 44);
            this.panelMoveFormLogin.TabIndex = 23;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblClose.Location = new System.Drawing.Point(327, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 27);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(50, 40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(260, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 21;
            this.pbLogo.TabStop = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(41, 145);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(274, 45);
            this.lblLoginTitle.TabIndex = 19;
            this.lblLoginTitle.Text = "CREATE YUBIKEY";
            // 
            // lYkeybackr
            // 
            this.lYkeybackr.AutoSize = true;
            this.lYkeybackr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lYkeybackr.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYkeybackr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lYkeybackr.Location = new System.Drawing.Point(64, 607);
            this.lYkeybackr.Name = "lYkeybackr";
            this.lYkeybackr.Size = new System.Drawing.Size(239, 20);
            this.lYkeybackr.TabIndex = 31;
            this.lYkeybackr.Text = "Create Account without  YubiKey";
            this.lYkeybackr.Click += new System.EventHandler(this.lYkeybackr_Click);
            // 
            // cbUSB
            // 
            this.cbUSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.cbUSB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUSB.DropDownWidth = 200;
            this.cbUSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUSB.FormattingEnabled = true;
            this.cbUSB.Location = new System.Drawing.Point(55, 436);
            this.cbUSB.Name = "cbUSB";
            this.cbUSB.Size = new System.Drawing.Size(260, 33);
            this.cbUSB.TabIndex = 35;
            // 
            // lblKeycardTitle
            // 
            this.lblKeycardTitle.AutoSize = true;
            this.lblKeycardTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeycardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblKeycardTitle.Location = new System.Drawing.Point(51, 411);
            this.lblKeycardTitle.Name = "lblKeycardTitle";
            this.lblKeycardTitle.Size = new System.Drawing.Size(99, 21);
            this.lblKeycardTitle.TabIndex = 34;
            this.lblKeycardTitle.Text = "USB-Device";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(55, 490);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 56);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // cbshowPassword
            // 
            this.cbshowPassword.AutoSize = true;
            this.cbshowPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbshowPassword.Location = new System.Drawing.Point(55, 373);
            this.cbshowPassword.Name = "cbshowPassword";
            this.cbshowPassword.Size = new System.Drawing.Size(128, 21);
            this.cbshowPassword.TabIndex = 42;
            this.cbshowPassword.Text = "Show Passwords";
            this.cbshowPassword.UseVisualStyleBackColor = true;
            this.cbshowPassword.CheckedChanged += new System.EventHandler(this.cbshowPassword_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel3.Controls.Add(this.tbConfPassword);
            this.panel3.Location = new System.Drawing.Point(55, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 36);
            this.panel3.TabIndex = 41;
            // 
            // tbConfPassword
            // 
            this.tbConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfPassword.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfPassword.Location = new System.Drawing.Point(3, 3);
            this.tbConfPassword.MaxLength = 512;
            this.tbConfPassword.Name = "tbConfPassword";
            this.tbConfPassword.PasswordChar = '*';
            this.tbConfPassword.Size = new System.Drawing.Size(254, 28);
            this.tbConfPassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(51, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Password";
            // 
            // FrmCreateYubiKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(360, 668);
            this.Controls.Add(this.cbshowPassword);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbUSB);
            this.Controls.Add(this.lblKeycardTitle);
            this.Controls.Add(this.lYkeybackr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lYKeyBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMoveFormLogin);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateYubiKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateYubiKey";
            this.Load += new System.EventHandler(this.FrmCreateYubiKey_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lYKeyBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMoveFormLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lYkeybackr;
        private System.Windows.Forms.ComboBox cbUSB;
        private System.Windows.Forms.Label lblKeycardTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbshowPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbConfPassword;
        private System.Windows.Forms.Label label4;
    }
}