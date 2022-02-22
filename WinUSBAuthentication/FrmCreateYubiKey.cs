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


        public FrmCreateYubiKey()
        {
            InitializeComponent();
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
            FrmCreateAcc frmca = new FrmCreateAcc();

            this.Hide();
            frmca.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

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
    }
}
