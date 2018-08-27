using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using SrednjeSkole_API.Models;
using SrednjeSkole_API.Util.BlobStorage;
using System.Web.Http;
using System.IO;
using System.Threading.Tasks;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Materijali")]
    public class MaterijaliController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ByPredmetId/{predmetId}")]
        public List<Materijali_Result> GetByPredmetId(int predmetId)
        {
            return db.ssp_Materijali_GetByPredmetId(predmetId).ToList();
        }

        [HttpGet]
        public List<Materijali> GetAll()
        {
            return db.Materijali.ToList();
        }

        [HttpPost]
        public IHttpActionResult PostMaterijali(Materijali m)
        {
                   
            //_context.Materijali.Add(m);
            //_context.SaveChanges();

            return Ok();
        }
    }
}
