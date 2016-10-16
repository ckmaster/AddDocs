using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class drawerTop
    {
        public List<drawer> drawers { get; set; } = new List<drawer>();
    }

    public class drawer
    {
        public string name { get; set; }
        public string id { get; set; }

        public drawer (string n, string i)
        {
            name = n;
            id = i;
        }
    }
}
