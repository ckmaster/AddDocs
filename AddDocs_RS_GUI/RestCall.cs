using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.IO;
using System.Windows.Forms;

namespace AddDocs_RS_GUI
{
    public class RestCall
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        public RestCall(string hash, string user, string pw, string uri, Method httpMethod, string contentType)
        {
            client = new RestClient(uri);
            request = new RestRequest(httpMethod);
            request.AddHeader("content-type", contentType);
            request.AddHeader("x-integrationserver-password", pw);
            request.AddHeader("x-integrationserver-username", user);
            request.AddHeader("x-integrationserver-session-hash", hash);
        }

        public string GetConnection()
        {
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("An error has occurred, failed to get connection:\r\n\r\n" + response.Content);
                System.Environment.Exit(1);
            }
            return response.Headers[0].Value.ToString();
        }

        public string PostDoc(ImageNowDoc doc)
        {
            request.AddParameter("application/xml", doc.CreatePostDocXML(), ParameterType.RequestBody);
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("An error has occurred, while creating the document:\r\n\r\n" + response.Content);
                return null;
            }
            string location = response.Headers[3].Value.ToString();
            string[] delims = { "document/" };
            string[] parts = location.Split(delims, StringSplitOptions.None);
            string docid = "";
            //After 50 documents have been added (100 operations on the same session hash)
            //A header gets added to response, Connection=close
            //The try catch handles that, may be a better way though
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

        public bool PostDocPage(string docid, string file)
        {
            request.AddHeader("x-integrationserver-resource-name", Path.GetFileName(file));
            byte[] fileBytes = File.ReadAllBytes(file);
            request.AddParameter("application/octet-stream", fileBytes, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("An error has occurred, while adding a page:\r\n\r\n" + response.Content);
                return false;
            }
            return true;
        }

        public void DeleteConnection()
        {
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Error deleting session\r\nBy default session will expire in 1 hour");
            }
        }
    }
}