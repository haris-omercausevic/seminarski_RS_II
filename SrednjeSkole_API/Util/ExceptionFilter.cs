using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace SrednjeSkole_API.Util
{
    public class ExceptionFilter: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is NotImplementedException)
            {
                HttpResponseMessage msg = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.PaymentRequired,
                    ReasonPhrase = "Payment required!",
                    Content = new StringContent("In order to access this method you need an activation code!")
                };

                actionExecutedContext.Response = msg;
            }
            else
                base.OnException(actionExecutedContext);
        }
    }
}