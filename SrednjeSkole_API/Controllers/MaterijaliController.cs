using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    public class MaterijaliController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities();        

        [HttpGet]
        [Route("ByPredmetId/{id}")]
        public List<Materijali> GetByPredmetId(int id)
        {
            return db.ssp_Materijali_GetByPredmetId(id).ToList();
        }
    }
}
