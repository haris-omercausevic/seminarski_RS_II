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
    [RoutePrefix("api/UceniciOcjene")]
    public class UceniciOcjeneController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);


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
