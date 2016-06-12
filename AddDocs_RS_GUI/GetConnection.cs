using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace AddDocs_RS_GUI
{
    public class GetConnection
    {
        public string ExecuteCall()
        {
            var client = new RestClient("http://localhost:8080/integrationserver/connection");
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/xml");
            request.AddHeader("x-integrationserver-password", "dwa");
            request.AddHeader("x-integrationserver-username", "ckidd");
            IRestResponse response = client.Execute(request);
            return response.Headers[0].Value.ToString();
        }
        //end ExecuteCall 
    }
}
