using SrednjeSkole_API.Models;
using SrednjeSkole_API.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

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

        [ResponseType(typeof(UceniciRazredi))]
        [ExceptionFilter]
        public IHttpActionResult PostUceniciRazredi(UceniciRazredi k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                db.ssp_UceniciRazredi_Insert(k.RedniBroj, k.SkolskaGodina, k.UcenikId, k.RazredId);
                //dodati u UceniciRazrediController

            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }


            return CreatedAtRoute("DefaultApi", new { id = k.UcenikRazrediId }, k);
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


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
