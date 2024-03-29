﻿using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/UceniciOcjene")]
    public class UceniciOcjeneController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ByUceniciRazredi/{ucenikId}/{razredId}")]
        public List<UceniciOcjene_Result> GetByRazredId(int ucenikId, int razredId)
        {
            return db.ssp_UceniciOcjene_GetByUcenikRazred(ucenikId, razredId).ToList();
        }

        [HttpGet]
        [Route("RazredIzvjestajStavke/{razredId}")]
        public List<RazredIzvjestajStavke_Result> GetRazredIzvjestajStavke(int razredId)
        {
            return db.ssp_UceniciOcjene_GetRazredIzvjestaj(razredId).ToList();
        }

        [HttpGet]
        [Route("PredmetiByUcenikLosProsjek/{razred}/{ucenikId}")]
        public List<Predmeti_Result> GetPredmetiByUcenikLosProsjek(int razredId, int ucenikId)
        {
            return db.ssp_UceniciOcjene_GetPredmetiByUcenikLosProsjek(razredId, ucenikId).ToList();
        }

        [HttpGet]
        [Route("UceniciByPredmetProsjek/{predmetId}")]
        public List<KorisniciSimple_Result> GetUceniciByPredmetProsjek(int predmetId)
        {
            return db.ssp_UceniciOcjene_GetUceniciByPredmetProsjek(predmetId).ToList();
        }


        // POST api/UceniciOcjene
        [ResponseType(typeof(void))]
        public IHttpActionResult PostUceniciOcjene(List<UceniciOcjene> uceniciOcjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                foreach (var item in uceniciOcjene)
                {
                    db.ssp_UceniciOcjene_Insert(item.PredajeId, item.UcenikId, item.Vrijednost, item.Datum, item.Napomena);
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}
