using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.IO;

namespace AddDocs_RS_GUI
{
    public class RestCall
    {
        public string server = "";
        public string port = "";
        public string username = "";
        public string password = "";

        public void LoadConfig ()
        {
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
                        server = parts[1];
                        break;
                    case 1:
                        port = parts[1];
                        break;
                    case 2:
                        username = parts[1];
                        break;
                    case 3:
                        password = parts[1];
                        break;
                }
            }
        }
        //end LoadConfig

        public string GetSessionHash()
        {
            var client = new RestClient("http://localhost:8080/integrationserver/connection");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/xml");
            request.AddHeader("x-integrationserver-password", "dwa");
            request.AddHeader("x-integrationserver-username", "ckidd");
            IRestResponse response = client.Execute(request);
            return response.Headers[0].Value.ToString();
        }
        //end GetSessionHash

        public string PostDoc(INOW_Doc doc, string hash)
        {
            LoadConfig();
            var client = new RestClient("http://" + server + ":" + port + "/integrationserver/document/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/xml");
            request.AddHeader("x-integrationserver-password", password);
            request.AddHeader("x-integrationserver-username", username);
            request.AddHeader("X-IntegrationServer-Session-Hash", hash);
            request.AddParameter("application/xml", doc.CreatePostDocXML(), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            //string hash = response.Headers[0].Value.ToString();
            string location = response.Headers[3].Value.ToString();
            string[] delims = { "document/" };
            string[] parts = location.Split(delims, StringSplitOptions.None);
            string docid = parts[1];
            return docid;
        }
        //end PostDoc

        public bool PostDocPage(string docid, string file, string hash)
        {
            var client = new RestClient("http://" + server + ":" + port + "/integrationserver/document/" + docid + "/page");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("x-integrationserver-resource-name", "dwa.tif");
            request.AddHeader("x-integrationserver-password", password);
            request.AddHeader("x-integrationserver-username", username);
            request.AddHeader("X-IntegrationServer-Session-Hash", hash);
            byte[] fileBytes = File.ReadAllBytes(file);
            request.AddParameter("application/octet-stream", fileBytes, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return true;
            }
            return false;
        }
        //end PostDocPage
    }
}