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
                        serializer.Serialize(jw, conf);
                    }
                }
                return true;
            } catch (FileNotFoundException)
            {
                return false;
            }
            
        }
    }
}
