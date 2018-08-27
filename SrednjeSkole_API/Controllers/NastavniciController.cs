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
    [RoutePrefix("api/Nastavnici")]
    public class NastavniciController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        //GET api/Nastavnici/id
        [HttpGet]
        [Route("ById/{id}")]
        public Korisnici_Result GetById(int id)
        {
            return db.ssp_Korisnici_GetById(id).FirstOrDefault();
        }

        // POST api/Nastavnici
        // POST api/Korisnici
        [HttpPost]
        [ResponseType(typeof(Nastavnici))]
        [ExceptionFilter]
        public IHttpActionResult PostNastavnici(Nastavnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                k.Id = Convert.ToInt32(db.ssp_Korisnici_Insert(k.Ime, k.Prezime, k.Email,
                       k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.JMBG, k.DatumRodjenja.Value.Date, null, null).FirstOrDefault());

                db.ssp_Nastavnici_Insert(k.Id, k.Zvanje, k.NaucnaOblast, k.GodinaZaposlenja);
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

        [HttpGet]
        [Route("NotRazrednici")]
        public List<Nastavnici_Result> GetNotRazrednici()
        {   
            return db.ssp_Nastavnici_NotRazrednici().ToList();
        }


        //PUT api/Korisnici/id

        [ResponseType(typeof(void))]
        public IHttpActionResult PutNastavnici(int id, Nastavnici k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != k.Id)
                return BadRequest();

            try
            {
                db.ssp_Korisnici_Update(id, k.Ime, k.Prezime, k.Email,
                        k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Aktivan, k.JMBG, k.DatumRodjenja.Value.Date);
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
