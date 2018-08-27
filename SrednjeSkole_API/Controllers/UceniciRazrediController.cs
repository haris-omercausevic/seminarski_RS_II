using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/UceniciRazredi")]
    public class UceniciRazrediController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ByRazredId/{razredId}")]
        public List<UceniciRazredi_Result> GetByRazredId(int razredId)
        {
            return db.ssp_UceniciRazredi_GetByRazredId(razredId).ToList();
        }

    }
}
