namespace WinUSBAuthentication
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblKeycardTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lregister = new System.Windows.Forms.Label();
            this.panelMoveFormLogin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbshowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelMoveFormLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.White;
            this.lblLoginTitle.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(41, 145);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(145, 50);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "LOG IN";
            // 
            // lblKeycardTitle
            // 
            this.lblKeycardTitle.AutoSize = true;
            this.lblKeycardTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeycardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblKeycardTitle.Location = new System.Drawing.Point(46, 218);
            this.lblKeycardTitle.Name = "lblKeycardTitle";
            this.lblKeycardTitle.Size = new System.Drawing.Size(87, 21);
            this.lblKeycardTitle.TabIndex = 2;
            this.lblKeycardTitle.Text = "Username";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(50, 40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(260, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lregister
            // 
            this.lregister.AutoSize = true;
            this.lregister.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lregister.Location = new System.Drawing.Point(84, 533);
            this.lregister.Name = "lregister";
            this.lregister.Size = new System.Drawing.Size(186, 21);
            this.lregister.TabIndex = 5;
            this.lregister.Text = "Dont have an Account?";
            this.lregister.Click += new System.EventHandler(this.lregister_Click);
            // 
            // panelMoveFormLogin
            // 
            this.panelMoveFormLogin.Controls.Add(this.lblClose);
            this.panelMoveFormLogin.Location = new System.Drawing.Point(-2, 0);
            this.panelMoveFormLogin.Name = "panelMoveFormLogin";
            this.panelMoveFormLogin.Size = new System.Drawing.Size(364, 44);
            this.panelMoveFormLogin.TabIndex = 8;
            this.panelMoveFormLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMoveFormLogin_MouseDown);
            this.panelMoveFormLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMoveFormLogin_MouseMove);
            this.panelMoveFormLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMoveFormLogin_MouseUp);
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
            this.lblClose.Click += new System.EventHandler(this.OnCloseButtonClicked);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.MaxLength = 24;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 28);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(46, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(51, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alternatively plug in your YubiKey";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(50, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 36);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Location = new System.Drawing.Point(50, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 36);
            this.panel2.TabIndex = 15;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(3, 3);
            this.tbPassword.MaxLength = 512;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(254, 28);
            this.tbPassword.TabIndex = 10;
            // 
            // cbshowPassword
            // 
            this.cbshowPassword.AutoSize = true;
            this.cbshowPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbshowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cbshowPassword.Location = new System.Drawing.Point(185, 373);
            this.cbshowPassword.Name = "cbshowPassword";
            this.cbshowPassword.Size = new System.Drawing.Size(122, 21);
            this.cbshowPassword.TabIndex = 17;
            this.cbshowPassword.Text = "Show Password";
            this.cbshowPassword.UseVisualStyleBackColor = true;
            this.cbshowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 413);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 56);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 594);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbshowPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMoveFormLogin);
            this.Controls.Add(this.lregister);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblKeycardTitle);
            this.Controls.Add(this.lblLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelMoveFormLogin.ResumeLayout(false);
            this.panelMoveFormLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblKeycardTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lregister;
        private System.Windows.Forms.Panel panelMoveFormLogin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbshowPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

