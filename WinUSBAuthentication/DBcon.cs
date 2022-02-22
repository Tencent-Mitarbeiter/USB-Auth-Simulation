using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Resources;
using System.Reflection;
using WinUSBAuthentication.resources;
using USBDetect;

namespace Ju_WorldData_Neu
{
    class DBase
    {
        private MySqlConnection con;

        public DBase(String server, String database, String uid, String password)
        {
            con = new MySqlConnection($"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password};");
        }

        /// <summary>
        ///     return true if the DeviceID are matching with the DeviceID in the database
        /// </summary>
        /// <param name="usb"></param>
        /// <returns>System.<see cref="System.Boolean">Boolean</see></returns>
        public bool CompareUSBID(USBDevice usb)
        {
            con.Open();

            // database : 'usb-devices'; Zeile : 'USB-ID';
            // Command zum Vergleichen der USB-ID
            var sqlQuery = string.Format(datenbank.selectUSBID, usb.DeviceID);

            MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@id", usb.DeviceID);
            cmd.Prepare();
            

            MySqlDataReader reader = cmd.ExecuteReader();

            bool hans = reader.Read();
            
            CloseConnection();
            
            return hans;
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public void DisposeConnection()
        {
            con.Dispose();
        }
    }
}