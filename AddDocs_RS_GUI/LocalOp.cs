using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddDocs_RS_GUI
{
    public class LocalOp
    {
        public IS_Info LoadConfig ()
        {
            IS_Info intServer = new IS_Info();
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(".\\config.txt"))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }
            }

            string[] delims = { ": " };
            for (int i = 0; i < 4; i++)
            {
                string[] parts = lines[i].Split(delims, StringSplitOptions.None);
                switch (i)
                {
                    case 0:
                        intServer.server = parts[1];
                        break;
                    case 1:
                        intServer.port = parts[1];
                        break;
                    case 2:
                        intServer.username = parts[1];
                        break;
                    case 3:
                        intServer.password = parts[1];
                        break;
                }
            }
            return intServer;
        }
        //end LoadConfig
    }
}
