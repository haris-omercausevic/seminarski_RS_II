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
    [RoutePrefix("api/Predaje")]
    public class PredajeController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpGet]
        [Route("ByNastavnikRazred/{nastavnikId}/{razredId}")]
        public List<Predaje_Result> GetByNastavnikRazred(int nastavnikId, int razredId)
        {
            return db.ssp_Predaje_GetByNastavnikRazred(nastavnikId, razredId).ToList();
        }
        [HttpGet]
        [Route("ByNastavnik/{nastavnikId}")]
        public List<Predaje_Result> GetByNastavnik(int nastavnikId)
        {
            return db.ssp_Predaje_GetByNastavnik(nastavnikId).ToList();
        }

        // POST api/Predaje
        [ResponseType(typeof(void))]
        public IHttpActionResult PostPredaje(List<Predaje_Result> predajeZaduzenja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                foreach (var item in predajeZaduzenja)
                {
                    db.ssp_Predaje_Insert(item.NastavnikId, item.PredmetId, item.RazredId);
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
