using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USBDetect;

namespace WinUSBAuthentication
{
    public partial class FrmCreateYubiKey : Form
    {

        private USBConnector usb;

        DBase dbcon;

        public FrmCreateYubiKey(DBase dbcon)
        {
            InitializeComponent();
            this.dbcon = dbcon;
        }

        /// <summary>
        /// Event: When a new external message get's retreived (For example when an usb device gets plugged in/out)
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            usb?.OnMessage(ref m);
        }

        private void lYKeyBack_Click(object sender, EventArgs e)
        {
            FrmLogIn frmli = new FrmLogIn();
            this.Hide();
            frmli.ShowDialog();
            this.Close();

        }

        private void lYkeybackr_Click(object sender, EventArgs e)
        {
            FrmCreateAcc frmca = new FrmCreateAcc(dbcon);

            this.Hide();
            frmca.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dbcon.AddYubiKey(tbUsername.Text, tbPassword.Text, cbUSB.SelectedItem.ToString());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
                dbcon.CloseConnection();
            }
        }
 
        private void OnUsbChange(USBDevice _=null) => Invoke(new Action(() => {
            this.cbUSB.Items.Clear();

            this.cbUSB.Items.AddRange(this.usb.CurrentDevices.ToArray());

            this.cbUSB.SelectedIndex = 0;
        }));

        private void FrmCreateYubiKey_Load(object sender, EventArgs e)
        {
            usb = new USBConnector(OnUsbChange,()=>OnUsbChange());
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbshowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //show password on CreateYubikey Form
            tbPassword.PasswordChar = cbshowPassword.Checked ? '\0' : '*';
        }

        int mov;
        int movX;
        int movY;

        private void panelMoveFormCYKey_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelMoveFormCYKey_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMoveFormCYKey_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
