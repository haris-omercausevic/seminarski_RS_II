using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Predaje")]
    public class PredajeController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ByNastavnikRazred/{nastavnikId}/{razredId}")]
        public List<Predaje_Result> GetByNastavnikRazred(int nastavnikId, int razredId)
        {
            return db.ssp_Predaje_GetByNastavnikRazred(nastavnikId, razredId).ToList();
        }
    }
}
