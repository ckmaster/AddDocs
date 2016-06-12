using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.IO;

namespace AddDocs_RS_GUI
{
    public abstract class RestCall
    {
        RestClient client;
        RestRequest request;

        public RestCall(string uri, RestSharp.Method method)
        {
            client = new RestClient(uri);
            request = new RestRequest(method);
        }
    }
}