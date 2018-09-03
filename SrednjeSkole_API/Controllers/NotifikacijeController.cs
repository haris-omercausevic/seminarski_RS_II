using ModernHttpClient;
using Newtonsoft.Json;
using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    public class NotifikacijeController : ApiController
    {
        private string TokenKey { get; } = "X-API-Token";
        private string TokenValue { get; } = "faaa3806f3a006141fd39f9e1c779b94ce02b4c4";
        private string AppCenterUri { get; } = "https://appcenter.ms/api/v0.1/apps/RSII_FIT/SrednjeSkole.Android/push/notifications";
        public static HttpClient client { get; set; }
        public string route { get; set; }

        public NotifikacijeController()
        {
            client = new HttpClient(new NativeMessageHandler());
            client.BaseAddress = new Uri(AppCenterUri);
            client.DefaultRequestHeaders.Add(TokenKey, TokenValue);
        }


        [HttpPost]
        public HttpResponseMessage PostNotifikacije(NotificationDefinition o)
        {
            StringContent jsonObject = new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8, "application/json");

            //jsonObject.Headers.Add("X-API-Token", "faaa3806f3a006141fd39f9e1c779b94ce02b4c4");            
            var temp = client.PostAsync("", jsonObject);
            return temp.Result;
        }
    }
}
