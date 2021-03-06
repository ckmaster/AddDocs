﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class DrawerRoot
    {
        public List<DrawerInfo> drawers { get; set; } = new List<DrawerInfo>();
    }

    public class DrawerInfo
    {
        public string name { get; set; }
        public string id { get; set; }

        public DrawerInfo (string n, string i)
        {
            name = n;
            id = i;
        }
    }
}
