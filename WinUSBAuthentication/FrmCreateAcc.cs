using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUSBAuthentication
{
    public partial class FrmCreateAcc : Form
    {

        DBase dbcon;
        
        public FrmCreateAcc(DBase dbcon)
        {
            InitializeComponent();
        }

        private void lCAccBack_Click(object sender, EventArgs e)
        {
            FrmLogIn frmli = new FrmLogIn();
            this.Hide();
            frmli.ShowDialog();
            this.Close();

        }

        private void lregYubiKey_Click(object sender, EventArgs e)
        {
            FrmCreateYubiKey frmcyk = new FrmCreateYubiKey(dbcon);
            this.Hide();
            frmcyk.ShowDialog();
            this.Close();

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbshowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //show password on CreateAcc Form
            tbConfPassword.PasswordChar = cbshowPassword.Checked ? '\0' : '*';
            tbPassword.PasswordChar = cbshowPassword.Checked ? '\0' : '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbPassword.Text.Equals(tbConfPassword.Text))
            {
                try
                {
                    dbcon.CreateUser(tbusername.Text, tbConfPassword.Text);
                } catch 
                {
                    MessageBox.Show("", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Die beiden Passwörter stimmen nicht überein!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        int mov;
        int movX;
        int movY;
        private void panelMoveFormCAcc_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelMoveFormCAcc_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMoveFormCAcc_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
