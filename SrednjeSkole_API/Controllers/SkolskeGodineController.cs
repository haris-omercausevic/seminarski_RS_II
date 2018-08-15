using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SrednjeSkole_API.Models;

namespace SrednjeSkole_API.Controllers
{
    public class SkolskeGodineController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities();

        // GET: api/SkolskeGodine
        public IQueryable<SkolskeGodine> GetSkolskeGodine()
        {
            return db.SkolskeGodine;
        }

        // GET: api/SkolskeGodine/5
        [ResponseType(typeof(SkolskeGodine))]
        public IHttpActionResult GetSkolskeGodine(int id)
        {
            SkolskeGodine skolskeGodine = db.SkolskeGodine.Find(id);
            if (skolskeGodine == null)
            {
                return NotFound();
            }

            return Ok(skolskeGodine);
        }

        // PUT: api/SkolskeGodine/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkolskeGodine(int id, SkolskeGodine skolskeGodine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skolskeGodine.SkolskaGodinaId)
            {
                return BadRequest();
            }

            db.Entry(skolskeGodine).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkolskeGodineExists(id))
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

        // POST: api/SkolskeGodine
        [ResponseType(typeof(SkolskeGodine))]
        public IHttpActionResult PostSkolskeGodine(SkolskeGodine skolskeGodine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SkolskeGodine.Add(skolskeGodine);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skolskeGodine.SkolskaGodinaId }, skolskeGodine);
        }

        // DELETE: api/SkolskeGodine/5
        [ResponseType(typeof(SkolskeGodine))]
        public IHttpActionResult DeleteSkolskeGodine(int id)
        {
            SkolskeGodine skolskeGodine = db.SkolskeGodine.Find(id);
            if (skolskeGodine == null)
            {
                return NotFound();
            }

            db.SkolskeGodine.Remove(skolskeGodine);
            db.SaveChanges();

            return Ok(skolskeGodine);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkolskeGodineExists(int id)
        {
            return db.SkolskeGodine.Count(e => e.SkolskaGodinaId == id) > 0;
        }
    }
}