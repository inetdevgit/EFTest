using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDAL.General
{
    public static class Info
    {
        private static string _userName = "sa";
        private static string _password = "@dmin123";
        private static string _server = ".\\SQLEXPRESS";
        private static string _database = "Testing";

        public static string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        public static string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public static string Server
        {
            get
            {
                return _server;
            }
            set
            {
                _server = value;
            }
        }
        public static string Database
        {
            get
            {
                return _database;
            }
            set
            {
                _database = value;
            }
        }
        public static string DatabaseConnectionString
        {
            get
            {
                return $"Server={Server};Database={Database};User Id={UserName};Password={Password};TrustServerCertificate=True";
            }
        }
    }
}
