using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

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
            client = new RestClient($"{conf.intServer.uri}/connection/");
            request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/xml");
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return response.Content;
            }
            return response.Headers[0].Value.ToString();
        }

        public string DeleteConnection()
        {
            client = new RestClient($"{conf.intServer.uri}/connection/");
            request = new RestRequest(Method.DELETE);
            request.AddHeader("content-type", "application/xml");
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return response.Content;
            }
            return "success";
        }

        public string PostDoc(ImageNowDoc doc)
        {
            client = new RestClient($"{conf.intServer.uri}/document/");
            request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/xml");
            request.AddParameter("application/xml", doc.CreatePostDocXML(), ParameterType.RequestBody);
            SetCommonHeaders();
            response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                return response.Content;
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

        public string PostDocPage(string docid, byte[] fileBytes, string filename)
        {
            client = new RestClient($"{conf.intServer.uri}/document/{docid}/page");
            request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("x-integrationserver-resource-name", filename);
            request.AddParameter("application/octet-stream", fileBytes, ParameterType.RequestBody);
            SetCommonHeaders();
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                return response.Content;
            }
            return "success";
        }

        public DrawerRoot GetDrawers()
        {
            client = new RestClient($"{conf.intServer.uri}/drawer");
            request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            SetCommonHeaders();
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return null;
            }
            string responseJson = "";
            responseJson = response.Content;
            DrawerRoot topLevel = JsonConvert.DeserializeObject<DrawerRoot>(responseJson);
            return topLevel;
        }

        public string RouteDoc(string docid, string queueid)
        {
            client = new RestClient($"{conf.intServer.uri}/workflowItem");
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            string jsonBody = $@"
            {{
                ""objectId"": ""{docid}"",
                ""itemType"": ""DOCUMENT"",
                ""workflowQueueId"": ""{queueid}"",
                ""itemPriority"": ""MEDIUM""
            }}";

            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);
            SetCommonHeaders ();
            response = client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                return response.Content;
            }
            return "success";
        }
        
    }
}