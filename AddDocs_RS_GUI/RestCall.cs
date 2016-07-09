using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
//using System.IO;
//using System.Windows.Forms;

namespace AddDocs_RS_GUI
{
    public class RestCall
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        Config conf;

        public RestCall(Config config)
        {
            conf = config;
        }

        public void SetCommonHeaders()
        {
            request.AddHeader("x-integrationserver-password", conf.intServer.password);
            request.AddHeader("x-integrationserver-username", conf.intServer.username);
            request.AddHeader("x-integrationserver-session-hash", conf.intServer.sessionHash);
        }

        public string GetConnection()
        {
            client = new RestClient($"http://{conf.intServer.hostname}:{conf.intServer.port}/integrationserver/connection/");
            request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/xml");
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //MessageBox.Show("An error has occurred, failed to get connection:\r\n\r\n" + response.Content);
                //System.Environment.Exit(1);
                return null;
            }
            return response.Headers[0].Value.ToString();
        }

        public bool DeleteConnection()
        {
            client = new RestClient($"http://{conf.intServer.hostname}:{conf.intServer.port}/integrationserver/connection/");
            request = new RestRequest(Method.DELETE);
            request.AddHeader("content-type", "application/xml");
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //MessageBox.Show("Error deleting session\r\nBy default session will expire in 1 hour");
                return false;
            }
            return true;
        }

        public string PostDoc(ImageNowDoc doc)
        {
            client = new RestClient($"http://{conf.intServer.hostname}:{conf.intServer.port}/integrationserver/document/");
            request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/xml");
            request.AddParameter("application/xml", doc.CreatePostDocXML(), ParameterType.RequestBody);
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                //MessageBox.Show("An error has occurred, while creating the document:\r\n\r\n" + response.Content);
                return null;
            }
            string location = response.Headers[3].Value.ToString();
            string[] delims = { "document/" };
            string[] parts = location.Split(delims, StringSplitOptions.None);
            string docid = "";
            //After 50 documents have been added (100 operations on the same session hash)
            //A header gets added to response, Connection=close
            try
            {
                docid = parts[1];
            }
            catch (IndexOutOfRangeException)
            {
                location = response.Headers[4].Value.ToString();
                parts = location.Split(delims, StringSplitOptions.None);
                docid = parts[1];
            }
            return docid;
        }

        public bool PostDocPage(string docid, byte[] fileBytes, string filename)
        {
            client = new RestClient($"http://{conf.intServer.hostname}:{conf.intServer.port}/integrationserver/document/{docid}/page");
            request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("x-integrationserver-resource-name", filename);
            request.AddParameter("application/octet-stream", fileBytes, ParameterType.RequestBody);
            SetCommonHeaders();
            response = client.Execute(request);

            //byte[] fileBytes = File.ReadAllBytes(file);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                //MessageBox.Show("An error has occurred, while adding a page:\r\n\r\n" + response.Content);
                return false;
            }
            return true;
        }
    }
}