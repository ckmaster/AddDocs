using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddDocs_RS_GUI
{
    public class InputOutput
    {
        public IntegrationServer LoadServerConfig()
        {
            IntegrationServer intServer = new IntegrationServer();
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(".\\server.txt"))
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
        //end LoadServerConfig

        public string LoadFileConfig()
        {
            string location = "";
            using (StreamReader sr = new StreamReader(".\\files.txt"))
            {
                while(!sr.EndOfStream)
                {
                    location = sr.ReadLine();
                }
            }
            return location;
        }
        //end LoadFileConfig

        public void SaveFileConfig(string location)
        {
            using (StreamWriter sw = new StreamWriter(".\\files.txt", false))
            {
                sw.WriteLine(location);
            }
        }
        //end SaveFileConfig

    }
}
