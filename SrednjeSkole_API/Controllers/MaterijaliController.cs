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
using System.Data.Entity.Core;
using SrednjeSkole_API.Util;
using System.Web.Http.Description;

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

        [ResponseType(typeof(Materijali))]
        [ExceptionFilter]
        public IHttpActionResult PostMaterijali(Materijali m)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                db.ssp_Materijali_Insert(m.Naziv, m.BlobName, m.Url, DateTime.Now, m.PredmetId, m.NastavnikId, 0, 0);
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }
            
            return CreatedAtRoute("DefaultApi", new { id = m.MaterijalId}, m);
        }
        private HttpResponseException CreateHttpExceptionMessage(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {
                ReasonPhrase = reason,
                StatusCode = code,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }
    }
}
