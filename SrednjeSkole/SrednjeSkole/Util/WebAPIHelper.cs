using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SrednjeSkole.Util
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

        public HttpResponseMessage PostActionResponse(string action, Object newObject)
        {
            try
            {
                StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(newObject), Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = client.PostAsync(route + "/" + action, jsonObject).Result;

                return responseMessage;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public HttpResponseMessage PutResponse(int id, Object existingObj)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(existingObj), Encoding.UTF8, "application/json");
            return client.PutAsync(route + "/" + id, jsonObject).Result;
        }
    }
}
