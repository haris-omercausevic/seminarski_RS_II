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
    [RoutePrefix("api/MaterijaliOcjene")]

    public class MaterijaliOcjeneController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);


        [HttpGet]
        [Route("IsOcijenjeno/{materijalId}/{ucenikId}")]
        public bool GetIsOcijenjeno(int materijalId, int ucenikId)
        {
            return db.MaterijaliOcjene.Any(x => x.MaterijalId == materijalId && x.UcenikId == ucenikId);
        }

        // POST api/MaterijaliOcjene
        [ResponseType(typeof(MaterijaliOcjene))]
        public IHttpActionResult PostMaterijaliOcjene(MaterijaliOcjene materijaliOcjene)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                materijaliOcjene.MaterijaliOcjeneId = Convert.ToInt32(db.ssp_MaterijaliOcjene_Insert(materijaliOcjene.MaterijalId, materijaliOcjene.UcenikId, materijaliOcjene.Ocjena).FirstOrDefault());
                db.ssp_Materijali_UpdateOcjene(materijaliOcjene.MaterijalId);
    }
            catch (Exception ex)
            {
                throw ex;
            }


            return CreatedAtRoute("DefaultApi", new { id = materijaliOcjene.MaterijaliOcjeneId }, materijaliOcjene);

        }


    }
}
