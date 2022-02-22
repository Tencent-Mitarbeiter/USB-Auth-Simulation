﻿using Ju_WorldData_Neu;
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
        private string dbserver = "192.168.235.166";
        private string dbdataBase = "usb-database";
        private string dbuser = "yeeeeeeeeeeeeet";
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

        }

        private void lregister_Click(object sender, EventArgs e)
        {
            FrmCreateAcc frmca = new FrmCreateAcc();

            this.Hide();
            frmca.ShowDialog();
            this.Close();
        }
            
    }
}