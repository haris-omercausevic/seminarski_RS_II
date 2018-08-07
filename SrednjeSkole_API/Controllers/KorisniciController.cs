using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
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

        //[HttpGet]
        //[Route("api/Korisnici/SearchByName /{name ?")]
        //public List<Korisnici_Result> SearchByName(string name = "")
        //{
        //    return db.esp_Korisnici_SelectByImePrezime(name).ToList();
        //}

        // GET api/Korisnici/username
        //[ResponseType(typeof(Korisnici))]
        //[Route("api/Korisnici/GetByUsername/{username}")]
        //public IHttpActionResult GetByUsername(string username)
        //{
        ////    Korisnici korisnici = db.esp_Korisnici_SelectByKorisnickoIme(username).FirstOrDefault();

        ////    if (korisnici == null)
        ////    {
        ////        return NotFound();
        ////    }

        //    return Ok();
        //}

    }
}
