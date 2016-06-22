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
        public IntegrationServer intServer = new IntegrationServer();
        public string fileLocation { get; set; }

        public void Initialize()
        {
            InputOutput local = new InputOutput();
            intServer = local.LoadServerConfig();
            fileLocation = local.LoadFileConfig();
        }
        //end Initialize

        public void GetConnection()
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.GET, "application/xml");
            intServer.sessionHash = rest.GetConnection();
        }
        //end GetConnection

        public string PostDoc(ImageNowDoc doc)
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/document/";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.POST, "application/xml");
            return rest.PostDoc(doc);
        }
        //end PostDoc

        public void PostDocPages(string docid, string file)
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/document/" + docid + "/page";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.POST, "application/octet-stream");
            rest.PostDocPage(docid, file);
        }
        //end PostDocPages

        public void DeleteConnection()
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.DELETE, "application/xml");
            rest.DeleteConnection();
        }
        //end DeleteConnection

        public void MultiDocMultiFile(string d, string f1, string f2, string f3, string f4, string f5, string dt)
        {
            GetConnection();
            string[] files = Directory.GetFiles(fileLocation);
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
        //end MultiDocMultiFile                  
    }                      
}                       