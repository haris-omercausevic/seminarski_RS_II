using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using SrednjeSkole_API.Models;

namespace SrednjeSkole_UI.Util
{
    public class WebAPIHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
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
            return client.PostAsJsonAsync(route, newObj).Result;
        }

        public HttpResponseMessage PutResponse(int id, Object existingObj)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObj).Result;
        }
    }
}
