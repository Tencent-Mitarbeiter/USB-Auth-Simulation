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
    public partial class error : Form
    {
        public error()
        {
            InitializeComponent();
        }

        private void lTryAgain_Click(object sender, EventArgs e)
        {
            FrmLogIn frmli = new FrmLogIn();
            this.Hide();
            frmli.ShowDialog();
            this.Close();
        }
    }
}
