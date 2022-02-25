using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USBDetect;

namespace WinUSBAuthentication
{

    public partial class FrmLogIn : Form
    {
        private string dbserver = "localhost";
        private string dbdataBase = "usb-database";
        private string dbuser = "root";
        private string dbpw = "";

        private DBase dbcon;

        private USBConnector usb;

        public FrmLogIn()
        {
            InitializeComponent();
            dbcon = new DBase(dbserver, dbdataBase, dbuser, dbpw);
            
            //Console.WriteLine(dbcon.AddUSBID("USB\\VID_4872&PID_81F1\\0X0001", "test9"));
        }

        /// <summary>
        /// Event: When a device change is detected
        /// </summary>
        /// <param name="devices">All found devices</param>
        private void OnUsbChange(USBDevice device) => Invoke(new Action(() => {
            Console.WriteLine("New device detected: " + device);
        }));
        
        /// <summary>
        /// Event: When a new external message get's retreived (For example when an usb device gets plugged in/out)
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            usb?.OnMessage(ref m);
        }

        private void OnCloseButtonClicked(object sender, EventArgs e) => this.Close();

        private void OnFormLoad(object sender, EventArgs e)
        {
            usb = new USBConnector(this.OnUsbChange);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        public void ContinueLogin()
        {
            
        }

        int mov;
        int movX;
        int movY;

        private void panelMoveFormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelMoveFormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMoveFormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //show password on Login Form
            tbPassword.PasswordChar = cbshowPassword.Checked ? '\0' : '*';
        }

        private void lregister_Click(object sender, EventArgs e)
        {
            FrmCreateAcc frmca = new FrmCreateAcc(dbcon);

            this.Hide();
            frmca.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
            //ich will nach hause
        {
            User user = dbcon.GetByPassword(tbUserName.ToString(), tbPassword.ToString()) ?? throw new ArgumentNullException(nameof(user), "User cannot be null"); ;

        }
    }
}