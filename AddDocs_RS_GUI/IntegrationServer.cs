using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class IntegrationServer
    {
        public string hostname { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string sessionHash { get; set; }

        public IntegrationServer () { }

        public IntegrationServer(string h, string p, string un, string pw, string sh)
        {
            hostname = h;
            port = p;
            username = un;
            password = pw;
            sessionHash = sh;
        }
    }
}