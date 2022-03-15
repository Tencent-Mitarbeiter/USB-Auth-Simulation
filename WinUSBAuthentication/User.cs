using MySql.Data.MySqlClient;
using System;

namespace WinUSBAuthentication
{
    public class User
    {
        public String Name { get; private set; }
        public String UsbID { get; private set; }
        public String Pwhash { get; private set; }
        public String Pwsalt { get; private set; }

        public static User Create(MySqlDataReader r)
        {
            return new User() {
                Name = (String)r["username"],
                UsbID = r["USB-ID"] == DBNull.Value ? null : (String)r["USB-ID"],
                Pwhash = (String)r["pwhash"],
                Pwsalt = (String)r["pwsalt"]
            };
        }
    }
}
