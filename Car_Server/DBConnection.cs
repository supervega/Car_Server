using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Car_Server
{
    public class DBConnection
    {
        private static string dbusername;
        private static string dbpassword;
        private static string dbservername;
        private static string hostname;
        private static string dbname;
        private static SqlConnection conn;

        public static string DBUserName
        {
            get
            {
                return dbusername;
            }
            set
            {
                dbusername = value;
            }
        }

        public static string DBPassword
        {
            get
            {
                return dbpassword;
            }
            set
            {
                dbpassword = value;
            }
        }

        public static string DBServerName
        {
            get
            {
                return dbservername;
            }
            set
            {
                dbservername = value;
            }
        }

        public static string HostName
        {
            get
            {
                return hostname;
            }
            set
            {
                hostname = value;
            }
        }

        public static string DBName
        {
            get
            {
                return dbname;
            }
            set
            {
                dbname = value;
            }
        }

        public static SqlConnection Conn
        {
            get
            {
                return conn;
            }
        }

        public DBConnection()
        { }

        public DBConnection(string username, string password, string host, string dbserver, string databasename)
        {
            DBUserName = username;
            DBPassword = password;
            HostName = host;
            DBServerName = dbserver;
            DBName = databasename;
        }

        public static void InitilizeConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=" + hostname + "\\" + dbservername + ";Initial Catalog=" + dbname + ";integrated security=false;user id=" + dbusername + ";password=" + dbpassword);
                MainForm.SEL.LBEvents.Items.Add("Data Base Connection has been initialized successfully.  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Data Base Connection has been initialized successfully.  ";                
            }
            catch (Exception ex)
            {
                MainForm.SEL.LBEvents.Items.Add("Error creating data base connection. (" + ex.Message + ")  " + DateTime.Now.ToString());
                MainForm.StatusMSG = "Error creating data base connection.  (" + ex.Message + ")  "; 
            }
        }

        public static bool checkInfo()
        {
            if (DBUserName == "" || DBPassword == "" || DBServerName == "" || HostName == "" || DBName == "")
                return true;
            else
            {
                MainForm.SEL.LBEvents.Items.Add("Registry info checked successffully.  " + DateTime.Now.ToString());
                return false;
            }
        }

        public static Connectionstate ConnectionState
        {
            get
            {
                if (Conn.State.ToString().ToLower() == "open")
                    return Connectionstate.Open;
                if (Conn.State.ToString().ToLower() == "closed")
                    return Connectionstate.Closed;
                return Connectionstate.unknown;
            }
        }

        public enum Connectionstate
        {
            Closed,Open,unknown
        }

    }
}
