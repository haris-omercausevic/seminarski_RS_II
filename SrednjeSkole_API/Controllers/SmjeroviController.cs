using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    public class SmjeroviController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

    }
}
