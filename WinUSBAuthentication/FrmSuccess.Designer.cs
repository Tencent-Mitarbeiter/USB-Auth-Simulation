namespace WinUSBAuthentication
{
    partial class FrmSuccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuccess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lSuccess = new System.Windows.Forms.Label();
            this.lBackToLogin = new System.Windows.Forms.Label();
            this.pMove = new System.Windows.Forms.Panel();
            this.lblNotClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(117, 42);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(278, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
            // 
            // lSuccess
            // 
            this.lSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lSuccess.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lSuccess.Location = new System.Drawing.Point(-1, 254);
            this.lSuccess.Name = "lSuccess";
            this.lSuccess.Size = new System.Drawing.Size(521, 25);
            this.lSuccess.TabIndex = 23;
            this.lSuccess.Text = "Logged in  successfully";
            this.lSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBackToLogin
            // 
            this.lBackToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBackToLogin.AutoSize = true;
            this.lBackToLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(94)))), ((int)(((byte)(172)))));
            this.lBackToLogin.Location = new System.Drawing.Point(216, 301);
            this.lBackToLogin.Name = "lBackToLogin";
            this.lBackToLogin.Size = new System.Drawing.Size(77, 25);
            this.lBackToLogin.TabIndex = 24;
            this.lBackToLogin.Text = "Logout";
            this.lBackToLogin.Click += new System.EventHandler(this.lBackToLogin_Click);
            // 
            // pMove
            // 
            this.pMove.Controls.Add(this.lblNotClose);
            this.pMove.Location = new System.Drawing.Point(-5, -1);
            this.pMove.Name = "pMove";
            this.pMove.Size = new System.Drawing.Size(525, 54);
            this.pMove.TabIndex = 25;
            this.pMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMove_MouseDown);
            this.pMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pMove_MouseMove);
            this.pMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pMove_MouseUp);
            // 
            // lblNotClose
            // 
            this.lblNotClose.AutoSize = true;
            this.lblNotClose.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblNotClose.Location = new System.Drawing.Point(486, 10);
            this.lblNotClose.Name = "lblNotClose";
            this.lblNotClose.Size = new System.Drawing.Size(22, 27);
            this.lblNotClose.TabIndex = 1;
            this.lblNotClose.Text = "x";
            this.lblNotClose.Click += new System.EventHandler(this.lblNotClose_Click);
            // 
            // FrmSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 362);
            this.Controls.Add(this.pMove);
            this.Controls.Add(this.lBackToLogin);
            this.Controls.Add(this.lSuccess);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "succsess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pMove.ResumeLayout(false);
            this.pMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lSuccess;
        private System.Windows.Forms.Label lBackToLogin;
        private System.Windows.Forms.Panel pMove;
        private System.Windows.Forms.Label lblNotClose;
    }
}