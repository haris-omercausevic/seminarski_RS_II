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
    public class SmjeroviController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities();

        // GET: api/Smjerovi
        public IQueryable<Smjerovi> GetSmjerovi()
        {
            return db.Smjerovi;
        }

        // GET: api/Smjerovi/5
        [ResponseType(typeof(Smjerovi))]
        public IHttpActionResult GetSmjerovi(int id)
        {
            Smjerovi smjerovi = db.Smjerovi.Find(id);
            if (smjerovi == null)
            {
                return NotFound();
            }

            return Ok(smjerovi);
        }

        // PUT: api/Smjerovi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSmjerovi(int id, Smjerovi smjerovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smjerovi.SmjerId)
            {
                return BadRequest();
            }

            db.Entry(smjerovi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmjeroviExists(id))
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

        // POST: api/Smjerovi
        [ResponseType(typeof(Smjerovi))]
        public IHttpActionResult PostSmjerovi(Smjerovi smjerovi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Smjerovi.Add(smjerovi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = smjerovi.SmjerId }, smjerovi);
        }

        // DELETE: api/Smjerovi/5
        [ResponseType(typeof(Smjerovi))]
        public IHttpActionResult DeleteSmjerovi(int id)
        {
            Smjerovi smjerovi = db.Smjerovi.Find(id);
            if (smjerovi == null)
            {
                return NotFound();
            }

            db.Smjerovi.Remove(smjerovi);
            db.SaveChanges();

            return Ok(smjerovi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SmjeroviExists(int id)
        {
            return db.Smjerovi.Count(e => e.SmjerId == id) > 0;
        }
    }
}