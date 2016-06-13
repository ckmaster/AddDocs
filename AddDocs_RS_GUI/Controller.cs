using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddDocs_RS_GUI
{
    public class Controller
    {
        public IS_Info intServer = new IS_Info();

        public void Initialize()
        {
            LocalOp local = new LocalOp();
            intServer = local.LoadConfig();
        }

        public void GetConnection()
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/connection/";
            RestCall rest = new RestCall(intServer.username, intServer.password, uri, RestSharp.Method.GET, "application/xml");
            intServer.sessionHash = rest.GetConnection();
        }

        public string PostDoc(INOW_Doc doc)
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/document/";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.POST, "application/xml");
            string docid = rest.PostDoc(doc);
            return docid;
        }

        public void PostDocPages(string docid, string file)
        {
            string uri = "http://" + intServer.server + ":" + intServer.port + "/integrationserver/document/" + docid + "/page";
            RestCall rest = new RestCall(intServer.sessionHash, intServer.username, intServer.password, uri, RestSharp.Method.POST, "application/octet-stream");
            rest.PostDocPage(docid, file);
        }

        public void DoWork(string d, string f1, string f2, string f3, string f4, string f5, string dt)
        {
            Initialize();
            GetConnection();
            string[] files = Directory.GetFiles("C:\\Import");
            foreach(string s in files)
            {
                INOW_Doc doc = new INOW_Doc("", d, f1, f2, f3, f4, Path.GetFileName(s), dt);
                string docid = PostDoc(doc);
                PostDocPages(docid, s);
            }              
        }                  
    }                      
}                          
                           