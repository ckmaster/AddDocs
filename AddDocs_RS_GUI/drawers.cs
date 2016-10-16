using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class drawerTop
    {
        public List<drawers> drawers { get; set; } = new List<drawers>();
    }

    public class drawers
    {
        public string name { get; set; }
        public string id { get; set; }

        public drawers (string n, string i)
        {
            name = n;
            id = i;
        }
    }
}
