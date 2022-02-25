using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           return new User() { Name = (String)r["username"], UsbID = (String)r["USB-ID"], Pwhash = (String)r["pwhash"], Pwsalt = (String)r["pwsalt"] }; 
        }
    }
}
