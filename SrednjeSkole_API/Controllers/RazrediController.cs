using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SrednjeSkole_API.Controllers
{
    public class RazrediController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        // GET: api/Razredi
        public IQueryable<Razredi> GetRazredi()
        {
            return db.Razredi;
        }

        // GET: api/Razredi/5
        [ResponseType(typeof(Razredi))]
        public IHttpActionResult GetRazredi(int id)
        {
            Razredi razredi = db.Razredi.Find(id);
            if (razredi == null)
            {
                return NotFound();
            }

            return Ok(razredi);
        }

        // PUT: api/Razredi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRazredi(int id, Razredi razredi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != razredi.RazredId)
            {
                return BadRequest();
            }

            db.Entry(razredi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazrediExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Razredi
        [ResponseType(typeof(Razredi))]
        public IHttpActionResult PostRazredi(Razredi r)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                r.RazredId = Convert.ToInt32(db.ssp_Razredi_Insert(r.RazredBrojcano,r.Odjeljenje,r.Oznaka,r.SkolskaGodinaId,r.NastavnikId,r.SmjerId ).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }


            return CreatedAtRoute("DefaultApi", new { id = r.RazredId }, r);
        }

        // DELETE: api/Razredi/5
        [ResponseType(typeof(Razredi))]
        public IHttpActionResult DeleteRazredi(int id)
        {
            Razredi razredi = db.Razredi.Find(id);
            if (razredi == null)
            {
                return NotFound();
            }

            db.Razredi.Remove(razredi);
            db.SaveChanges();

            return Ok(razredi);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
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

        private bool RazrediExists(int id)
        {
            return db.Razredi.Count(e => e.RazredId== id) > 0;
        }
    }
}
