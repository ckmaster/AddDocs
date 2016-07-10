using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace AddDocs_RS_GUI
{
    public class LocalOp
    {
        public Config LoadConfig()
        {
            string configFile = ".\\config.json";
            try
            {
                string json = File.ReadAllText(configFile);
                Config conf = JsonConvert.DeserializeObject<Config>(json);
                return conf;
            } catch (FileNotFoundException)
            {
                return null;
            }
        }

        public bool SaveConfig(Config conf)
        {
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamWriter sw = new StreamWriter(".\\config.json"))
                {
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        //Since the IntegrationServer objects holds session hash the hash gets written out and picked up on next run
                        //However the next run disregards it as an invalid session
                        serializer.Serialize(jw, conf);
                    }
                }
                return true;
            } catch (FileNotFoundException)
            {
                return false;
            } 
        }

        public void DefaultConfig()
        {
            IntegrationServer intServer = new IntegrationServer("localhost", "8080", "integrationserver", "administrator", "ImageNow!", "");
            string folder = "C:\\Program Files (x86)\\ImageNow\\Demo Images";
            string file = "C:\\Program Files (x86)\\ImageNow\\Demo Images\\Demo 01.tif";
            Config conf = new Config(intServer, folder, file);
            SaveConfig(conf);
        }

    }
}
