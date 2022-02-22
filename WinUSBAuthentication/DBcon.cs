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
using System.Security.Cryptography;

namespace WinUSBAuthentication
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

        //public bool AddUSBID(USBDevice usb)
        public bool AddUSBID(String usb, String name, String pwhash, String pwsalt)
        {
            con.Open();

            // Hier die SQL INSERT Query einfügen für das Hinzufügen einer USB-ID
            // `ID` -> Auto_increment
            // `USB-ID` -> Text
            // `username` -> Text

            //var sqlQuery = string.Format(datenbank., usb.DeviceID);

            //var sqlQuery = $"INSERT INTO `usb-devices` (`ID`, `USB-ID`, `username`, `pwhash`, `pwsalt`) VALUES (NULL, '{usb}', '{name}', '{pwhash}', '{pwsalt}');";
            //INSERT INTO `usb-devices` (`ID`, `USB-ID`, `username`, `pwhash`, `pwsalt`) VALUES (NULL, '{@usb}', '{@name}', '{@pwhash}', '{@pwsalt}');";

           

            MySqlCommand cmd = new MySqlCommand(datenbank.insertUSB, con);
            //cmd.Parameters.AddWithValue("@id", usb);
            //cmd.Parameters.AddWithValue("@name", name);
            //cmd.Prepare();
            
            try
            {
                cmd.ExecuteReader();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            CloseConnection();

            if (cmd.LastInsertedId > 0)
            {
                return true;
            }
            return false;
        }


        public User GetByPassword(string username, string password)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(datenbank.selectByPassword, con);
            cmd.Parameters.AddWithValue("@uname", username);
            cmd.Parameters.AddWithValue("@pw", password);
            cmd.Prepare();

            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                return User.Create(r);
            }

            return null;
        }

        public User GetByYubiKey(string usbID)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand(datenbank.selecctYubiKey, con);
            cmd.Parameters.AddWithValue("@id",usbID);
            cmd.Prepare();

            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                return User.Create(r);
            }

            return null;
        }

        public long CreateUser(string username, string password)
        {
            Random rdm = new Random();
            String pwsalt = "";
            for (int i = 0; i < rdm.Next(30, 60); i++)
            {
                pwsalt += (char)rdm.Next(1, 256);
            }

            con.Open();
            MySqlCommand cmd = new MySqlCommand(datenbank.selecctYubiKey, con);
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@pwhash", password);
            cmd.Parameters.AddWithValue("@pwsalt", pwsalt);
            cmd.Parameters.AddWithValue("@usb", "NULL");
            cmd.Prepare();

            try
            {
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }

            CloseConnection();

            return cmd.LastInsertedId;

            // Nutzer speichern (Mit gehashtem passwort & random salt)
            // Return user-id
        }



        public void OpenConnection()
        {
            con.Open();
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