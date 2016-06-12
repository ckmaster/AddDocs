using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class IS_Info
    {
        public string server { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string sessionHash { get; set; }

        public IS_Info(){ }
    }
}
