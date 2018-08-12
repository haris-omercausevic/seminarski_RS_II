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
    public class PredmetiController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities();

        // GET: api/Predmeti
        public IQueryable<Predmeti> GetPredmeti()
        {
            return db.Predmeti;
        }

        // GET: api/Predmeti/5
        [ResponseType(typeof(Predmeti))]
        public IHttpActionResult GetPredmeti(int id)
        {
            Predmeti predmeti = db.Predmeti.Find(id);
            if (predmeti == null)
            {
                return NotFound();
            }

            return Ok(predmeti);
        }

        // PUT: api/Predmeti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPredmeti(int id, Predmeti predmeti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != predmeti.PredmetId)
            {
                return BadRequest();
            }

            db.Entry(predmeti).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PredmetiExists(id))
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

        // POST: api/Predmeti
        [ResponseType(typeof(Predmeti))]
        public IHttpActionResult PostPredmeti(Predmeti predmeti)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Predmeti.Add(predmeti);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = predmeti.PredmetId }, predmeti);
        }

        // DELETE: api/Predmeti/5
        [ResponseType(typeof(Predmeti))]
        public IHttpActionResult DeletePredmeti(int id)
        {
            Predmeti predmeti = db.Predmeti.Find(id);
            if (predmeti == null)
            {
                return NotFound();
            }

            db.Predmeti.Remove(predmeti);
            db.SaveChanges();

            return Ok(predmeti);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PredmetiExists(int id)
        {
            return db.Predmeti.Count(e => e.PredmetId == id) > 0;
        }
    }
}