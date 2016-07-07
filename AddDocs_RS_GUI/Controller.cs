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

        public void PostDocPage(string docid, string file)
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/document/" + docid + "/page";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.POST, "application/octet-stream");
            rest.PostDocPage(docid, file);
        }

        public void PostDocPageRapid(string docid, string file)
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/document/" + docid + "/page";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.POST, "application/octet-stream");
            rest.PostDocPageRapid(docid, file);
        }

        public void DeleteConnection()
        {
            string uri = "http://" + conf.intServer.hostname + ":" + conf.intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(conf.intServer.sessionHash, conf.intServer.username, conf.intServer.password, uri, RestSharp.Method.DELETE, "application/xml");
            rest.DeleteConnection();
        }

        public void MultiDocMultiFile(string d, string f1, string f2, string f3, string f4, string f5, string dt)
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
                    PostDocPage(docid, s);
                }
            }
            DeleteConnection();
        }
        
        public void MultiDocSingleFile(string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            GetConnection();
            string temp = Path.GetFileName(conf.filePath);
            if (temp.Length > 40)
            {
                temp = temp.Substring(0, 39);
            }
            for (int i = 0; i < repeat; i++)
            {   
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, temp, Guid.NewGuid().ToString(), dt);
                string docid = PostDoc(doc);
                if (docid != null)
                {
                    PostDocPage(docid, conf.filePath);
                }
            }
            DeleteConnection();
        }

        public void MultiDocRapidFire (string d, string f1, string f2, string f3, string f4, string f5, string dt, int repeat)
        {
            GetConnection();
            for (int i = 0; i < repeat; i ++)
            {
                ImageNowDoc doc = new ImageNowDoc("", d, f1, f2, f3, f4, Guid.NewGuid().ToString(), dt);
                PostDoc(doc);
            }
            DeleteConnection();
        }

        public void SingleDocSingleFile (string docid, int repeat)
        {
            GetConnection();
            for (int i = 0; i < repeat; i++)
            {
                PostDocPage(docid, conf.filePath);
            }
            DeleteConnection();
        }

        public void SingleDocRapidFire (string docid, int repeat)
        {
            GetConnection();
            for (int i = 0; i < repeat; i++)
            {
                PostDocPageRapid(docid, conf.filePath);
            }
            DeleteConnection();
        }

        public void SingleDocMultiFile(string docid)
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
                PostDocPage(docid, s);
            }
            DeleteConnection();
        }
    }                      
}                       