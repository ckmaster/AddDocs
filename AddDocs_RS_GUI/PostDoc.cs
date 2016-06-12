using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AddDocs_RS_GUI
{
    public class PostDoc
    {
        public string ExecuteCall(INOW_Doc doc, string hash, string server, string port, string username, string password)
        {
            var client = new RestClient("http://" + server + ":" + port + "/integrationserver/document/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/xml");
            request.AddHeader("x-integrationserver-password", password);
            request.AddHeader("x-integrationserver-username", username);
            request.AddHeader("X-IntegrationServer-Session-Hash", hash);
            request.AddParameter("application/xml", doc.CreatePostDocXML(), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            string location = response.Headers[3].Value.ToString();
            string[] delims = { "document/" };
            string[] parts = location.Split(delims, StringSplitOptions.None);
            string docid = parts[1];
            return docid;
        }
    }
}
