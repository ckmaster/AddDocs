using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.IO;

namespace AddDocs_RS_GUI
{
    public class PostDocPage
    {
        public void ExecuteCall(string hash, string server, string port, string username, string password, string docid, string file)
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
        }
        
    }
}
