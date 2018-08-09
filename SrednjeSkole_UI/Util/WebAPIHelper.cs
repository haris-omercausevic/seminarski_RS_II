using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using SrednjeSkole_API.Models;
using ModernHttpClient;
using Newtonsoft.Json;

namespace SrednjeSkole_UI.Util
{
    public class WebAPIHelper
    {
        public static HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient(new NativeMessageHandler());
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }
        public HttpResponseMessage GetResponse(string parameter = "")
        {
            return client.GetAsync(route + "/" + parameter).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }       

        public HttpResponseMessage PostResponse(Object newObj)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(newObj), Encoding.UTF8, "application/json");
            return client.PostAsync(route, jsonObject).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObj)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(existingObj), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }
    }
}
