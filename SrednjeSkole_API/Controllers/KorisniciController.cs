using SrednjeSkole_API.Models;
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
    public class KorisniciController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        //GET api/Korisnici/id

        [HttpGet]
        public List<Korisnici_Result> GetKorisnici()
        {
            return db.ssp_Korisnici_SelectAll().ToList();
        }

        [HttpGet]
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici k = db.Korisnici.Find(id);

            if (k == null)
                return NotFound();

            return Ok(k);
        }
        //GET api/Korisnici/Pretraga
        [HttpGet]
        [Route("api/Korisnici/Pretraga/{name?}")]
        public List<Korisnici_Result> Pretraga(string ime = null, string prezime = null, string email = null, int? ulogaId = null)
        {
            return db.ssp_Korisnici_Pretraga(ime,prezime,email,ulogaId).ToList();
        }


        // POST api/Korisnici
        [ResponseType(typeof(Korisnici))]
        //[ExceptionFilter]
        public IHttpActionResult PostKorisnici(Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                k.Id = Convert.ToInt32(db.ssp_Korisnici_Insert(k.Ime, k.Prezime, k.Email,
                       k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash,k.JMBG,k.DatumRodjenja).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }

            foreach (var item in k.Uloge)
            {
                db.ssp_KorisniciUloge_Insert(k.Id, item.UlogaId);
            }

            return CreatedAtRoute("DefaultApi", new { id = k.Id }, k);
        }

        //PUT api/Korisnici/id

        [ResponseType(typeof(void))]
        public IHttpActionResult PutKorisnici(int id, Korisnici k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != k.Id)
                return BadRequest();

            db.ssp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email,
                k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Aktivan, k.JMBG, k.DatumRodjenja);

            return StatusCode(HttpStatusCode.NoContent);
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
