using SrednjeSkole_API.Models;
using SrednjeSkole_API.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Korisnici")]
    public class KorisniciController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);


        //GET api/Korisnici/id
        [HttpGet]
        [Route("ById/{id}")]        
        public Korisnici_Result GetById(int id)
        {
            return db.ssp_Korisnici_GetById(id).FirstOrDefault();            
        }
        [HttpGet]
        [Route("ByUsername/{username}")]
        public IHttpActionResult GetByUserName(string username)
        {
            Korisnici k = db.Korisnici.Where(x => x.KorisnickoIme == username).Include(x => x.KorisniciUloge).FirstOrDefault();
            if (k == null)
                return NotFound();

            return Ok(k);
        }

        //GET api/korisnici/pretraga?ime=haris&prezime=omercausevic&ulogaId=4
        [HttpGet]
        //[ActionName("Pretraga")]
        public List<KorisniciPretraga_Result> Pretraga(string ime = "", string prezime = "", int? ulogaId = null)
        {
            return db.ssp_Korisnici_Pretraga(ime,prezime,ulogaId).ToList();
        }

        // POST api/Korisnici
        [ResponseType(typeof(Korisnici))]
        [ExceptionFilter]
        public IHttpActionResult PostKorisnici(Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                k.Id = Convert.ToInt32(db.ssp_Korisnici_Insert(k.Ime, k.Prezime, k.Email,
                       k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash,k.JMBG,k.DatumRodjenja.Value.Date,null,null).FirstOrDefault());
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

            try
            {
                db.ssp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email,
                        k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Aktivan, k.JMBG, k.DatumRodjenja.Value.Date);
                db.ssp_KorisniciUloge_Remove(k.Id);
                foreach (var item in k.Uloge)
                {
                    db.ssp_KorisniciUloge_Insert(k.Id, item.UlogaId);
                }
            }
            catch (EntityException ex)
            {

                if (ex.InnerException != null)
                    throw CreateHttpExceptionMessage(Util.ExceptionHandler.HandleException(ex),
                                                     HttpStatusCode.Conflict);
            }

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
