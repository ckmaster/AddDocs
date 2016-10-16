using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class IntegrationServer
    {
        public string uri { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string sessionHash { get; set; }

        public IntegrationServer () { }

        public IntegrationServer(string u, string un, string pw, string sh)
        {
            uri = u;
            username = un;
            password = pw;
            sessionHash = sh;
        }
    }
}