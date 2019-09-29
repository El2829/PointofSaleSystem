using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System_for_RERB_Enterprise
{
    class Connection
    {
        private static string server = "";
        private static string database = "";
        private static string port = "";
        private static string user = "";
        private static string password = "";
        private static string connstr = "";

        public static string getConnectionStr()
        {
            return connstr = "SERVER=" + server + ";" + "PORT=" + port + ";" + "USER=" + user + ";" + "DATABASE=" + database + ";" + "PASSWORD=" + password + ";";
        }


        public static void setServer(string server)
        {
            Connection.server = server;
        }
        public static void setDatabase(string database)
        {
            Connection.database = database;
        }

        public static void setPort(string port)
        {
            Connection.port = port;
        }
        public static void setUser(string user)
        {
            Connection.user = user;
        }
        public static void setPassword(string pass)
        {
            Connection.password = pass;
        }
    }
}
