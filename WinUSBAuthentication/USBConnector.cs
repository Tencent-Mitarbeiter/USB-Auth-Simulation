using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace USBDetect
{
    public class USBDevice
    {
        public string DeviceID;
        public string Type;

        public override string ToString()
        {
            return this.DeviceID;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DevBroadcastVolume
    {
        public int Size;
        public int DeviceType;
        public int Reserved;
        public int Mask;
        public Int16 Flags;
    }

    public class USBConnector
    {
        // Constants for the usb device
        private const int WM_DEVICECHANGE = 0x219;

        // Callback when a single new usb device gets detected
        private readonly Action<USBDevice> onUSBChange;

        // Callback when new usb devices have been added or removed (so just the generall list got updated)
        private readonly Action<IEnumerable<USBDevice>> onListUpdate;

        // Callback when the first usb device load got executed
        private readonly Action onLoad;

        // Devices that have been found previously
        public IEnumerable<USBDevice> CurrentDevices { get; private set; }

        /// <param name="onUSBChange">Event-callback when a new usb device get's added</param>
        public USBConnector(Action<USBDevice> onUSBChange = null, Action<IEnumerable<USBDevice>> onListUpdate = null, Action onLoad = null)
        {
            // Sets the callbacks
            this.onUSBChange = onUSBChange;
            this.onListUpdate = onListUpdate;
            this.onLoad = onLoad;

            // Executes the first scan
            this.ScanForDevices();
        }

        /// <summary>
        /// Initalizes a new scan for devices
        /// </summary>
        private void ScanForDevices()
        {
            // Starts a new thread to scan for devices
            new Thread(new ThreadStart(this.OnDeviceScan)).Start();
        }

        /// <summary>
        /// Actually performs a scan for all usb devices that are plugged into this computer.
        /// </summary>
        /// <returns>An enumerable with all detected usbdevices</returns>
        private IEnumerable<USBDevice> SelectCurrentUSBDevices()
        {
            try
            {
                // List with found usb devices
                List<USBDevice> foundDevices = new List<USBDevice>();

                // Selects all usb devices from the win32 api Win32_USBHub
                ManagementObjectCollection collection;
                using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                    collection = searcher.Get();

                // Creates usb devices from all
                foreach (var device in collection)
                    // Creates the device
                    foundDevices.Add(new USBDevice
                    {
                        DeviceID = (string)device.GetPropertyValue("DeviceID"),
                        Type = (string)device.GetPropertyValue("Description"),
                    });

                // Returns the found devices
                return foundDevices;
            }
            // Ignores any exceptions
            catch (Exception e) {
                Console.WriteLine(e);
                return default;
            }
        }

        /// <summary>
        /// Event: When a new device scan list inited. This will be called in a different thread
        /// </summary>
        private void OnDeviceScan()
        {
            // Checks if this is the first scan
            if(this.CurrentDevices == null)
            {
                // Performs the first scan
                this.CurrentDevices = this.SelectCurrentUSBDevices().ToArray();

                // Executes the load event
                this.onLoad?.Invoke();
                return;
            }

            // Selects all current devices again
            var newDetected = this.SelectCurrentUSBDevices();

            // Filters all newly added devices
            var newDevs = newDetected.Where(dev => !this.CurrentDevices.Any(d2=>d2.DeviceID==dev.DeviceID)).ToArray();

            // Updates the previous devices
            this.CurrentDevices = newDetected;

            // Executes the event
            this.onListUpdate?.Invoke(this.CurrentDevices);

            // Executes the event for every newly found device
            if(this.onUSBChange != null)
                foreach(var dev in newDevs)
                    this.onUSBChange(dev);

        }

        /// <summary>
        /// Message event that has to be called from the outside (a form.
        /// Just override your WndProc method and pass the message reference to this function
        /// </summary>
        /// <param name="m">The message</param>
        public void OnMessage(ref Message m)
        {
            // Checks if the device got changed
            if  (m.Msg != WM_DEVICECHANGE)
                return;


            // Inits a new scan
            this.ScanForDevices();
        }
    }
}