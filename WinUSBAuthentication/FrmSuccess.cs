using System;
using System.Windows.Forms;

namespace WinUSBAuthentication
{
    public partial class FrmSuccess : Form
    {
        public FrmSuccess(User user)
        {
            InitializeComponent();
            lSuccess.Text = $"{user.Name} logged in successfully";

        }

        private void lBackToLogin_Click(object sender, EventArgs e)
        {
            FrmLogIn frmli = new FrmLogIn();
            this.Hide();
            frmli.ShowDialog();
            this.Close();
        }

        int mov;
        int movX;
        int movY;

        private void pMove_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pMove_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void lblNotClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ja das hättest du wohl gerne. (☞ﾟヮﾟ)☞", "Nö",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
