using System;
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
        }

        /// <summary>
        /// Event: When a device change is detected
        /// </summary>
        /// <param name="devices">All found devices</param>
        private void OnUsbChange(USBDevice device) => Invoke(new Action(() => {

            try
            {
                // Tries to login the user
                var user = dbcon.CompareUSBID(device);

                if (user == null)
                {
                    MessageBox.Show("USB-Gerät wurde nicht gefunden, bitte nutzen Sie einen registrierten Dongle.", "Fehler beim Login");
                    return;
                }

                // Opens the success form
                this.Hide();
                new FrmSuccess(user).ShowDialog();
                this.Close();
            }
            catch
            {
                dbcon.CloseConnection();
                MessageBox.Show("Fehler bei der Datenbankverbindung.", "Datenbank-Fehler");
            }

        }));
        
        /// <summary>
        /// Event: When a new external message get's retreived (For example when an usb device gets plugged in/out)
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (this.Visible)
                usb?.OnMessage(ref m);
        }

        private void OnCloseButtonClicked(object sender, EventArgs e) => this.Close();

        private void OnFormLoad(object sender, EventArgs e) => usb = new USBConnector(this.OnUsbChange);

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
        {
            if (tbUserName.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Das Feld Username oder Password dürfen nicht leer sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = dbcon.GetByPassword(tbUserName.Text.ToString(), tbPassword.Text.ToString());
                
                if(user == null)
                {
                    MessageBox.Show("Nicht erfolgreich eingeloggt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Opens the success form
                this.Hide();
                new FrmSuccess(user).ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbcon.CloseConnection();
            }
        }

        private void bAddYKey_Click(object sender, EventArgs e)
        {
            FrmCreateYubiKey frmcyk = new FrmCreateYubiKey(dbcon);
            this.Hide();
            frmcyk.ShowDialog();
            this.Close();
        }
    }
}