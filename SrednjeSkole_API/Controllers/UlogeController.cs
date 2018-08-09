using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SrednjeSkole_API.Models;


namespace SrednjeSkole_API.Controllers
{
    public class UlogeController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        //api/Uloge
        [HttpGet]
        [Route("api/Uloge/{naziv?}")]
        public List<Uloge> Uloge(string naziv = null)
        {
            return db.Uloge.Where(x => x.Naziv.ToLower() == naziv.ToLower() || naziv == null).ToList();
        }

        //[HttpGet]
        //[Route("api/Uloge/GetByKorisnikId/{id?}")]
        //public List<Uloge> GetByKorisnikId(string id = null)
        //{
        //    return db.Uloge.Where(x => x.Naziv.ToLower() == naziv.ToLower() || naziv == null).ToList();
        //}

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
