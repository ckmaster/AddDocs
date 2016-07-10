using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDocs_RS_GUI
{
    public class Config
    {
        public IntegrationServer intServer { get; set; }
        public string folderPath { get; set; }
        public string filePath { get; set; }

        public Config() { }

        public Config(IntegrationServer intS, string fop, string fip)
        {
            intServer = intS;
            folderPath = fop;
            filePath = fip;
        }
    }
}
