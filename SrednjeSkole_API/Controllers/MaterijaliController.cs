using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Materijali")]
    public class MaterijaliController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities();        

        [HttpGet]
        [Route("ByPredmetId/{predmetId}")]
        public List<Materijali> GetByPredmetId(int predmetId)
        {
            return db.ssp_Materijali_GetByPredmetId(predmetId).ToList();
        }

        [HttpGet]
        public List<Materijali> GetAll()
        {
            return db.Materijali.ToList();
        }
    }
}
