using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AddDocs_RS_GUI
{
    public class Controller
    {
        public Config conf;

        public void Initialize()
        {
            conf = new LocalOp().LoadConfig();
            if (conf == null)
            {
                MessageBox.Show("Failed to load config file, program will now exit");
                Environment.Exit(1);
            }
        }

        public void GetConnection()
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.GET, "application/xml");
            conf.intServer.sessionHash = rest.GetConnection();
        }

        public string PostDoc(ImageNowDoc doc)
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/document/";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.POST, "application/xml");
            return rest.PostDoc(doc);
        }

        public void PostDocPages(string docid, string file)
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/document/" + docid + "/page";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.POST, "application/octet-stream");
            rest.PostDocPage(docid, file);
        }

        public void DeleteConnection()
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.DELETE, "application/xml");
            rest.DeleteConnection();
        }

        public void DoWork(string d, string f1, string f2, string f3, string f4, string f5, string dt)
        {
            GetConnection();
            string[] files = Directory.GetFiles(conf.folderPath);
            foreach(string s in files)
            {
                string temp = Path.GetFileName(s);
                if (temp.Length > 40)
                {
                    temp = temp.Substring(0, 39);
                }
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, temp, Guid.NewGuid().ToString(), dt);
                string docid = PostDoc(doc);
                if (docid != null)
                {
                    PostDocPages(docid, s);
                }
            }
            DeleteConnection();
        }             
    }                      
}                       