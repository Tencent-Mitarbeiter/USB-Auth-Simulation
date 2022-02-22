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
        public FrmCreateAcc()
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
            FrmCreateYubiKey frmcyk = new FrmCreateYubiKey();
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
            if(cbshowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbConfPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbConfPassword.PasswordChar = '*';
            }
            
        }
    }
}
