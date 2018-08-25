﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using SrednjeSkole_API.Models;
using System.Web.Http;
using System.Web.Http.Description;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Obavijesti")]
    public class ObavijestiController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ById/{id}")]
        public Obavijesti_Result GetById(int id)
        {
            return db.ssp_Obavijesti_GetById(id).FirstOrDefault();
        }


        [HttpGet]
        [Route("Pretraga/{naziv?}")]
        public List<Obavijesti_Result> Pretraga(string naziv = "")
        {
            return db.ssp_Obavijesti_Pretraga(naziv).ToList();
        }

        [ResponseType(typeof(Obavijesti))]        
        public IHttpActionResult PostObavijesti(Obavijesti o)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                o.ObavijestId = Convert.ToInt32(db.ssp_Obavijesti_Insert(o.Naslov, o.Tekst, o.KorisnikId));
            }
            catch (Exception)
            {
                throw;
            }           

            return CreatedAtRoute("DefaultApi", new { id = o.ObavijestId }, o);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult PutObavijesti(int id, Obavijesti k)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != k.ObavijestId)
                return BadRequest();

            try
            {
                db.ssp_Obavijesti_Update(id, k.Naslov, k.Tekst);       
            }
            catch (Exception ex)
            {

                throw;
            }

            return StatusCode(HttpStatusCode.NoContent);
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
