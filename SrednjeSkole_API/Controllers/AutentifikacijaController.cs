using SrednjeSkole_API.Models;
using SrednjeSkole_API.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SrednjeSkole_API.Controllers
{
    [RoutePrefix("api/Autentifikacija")]
    public class AutentifikacijaController : ApiController
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        [HttpPost]
        [Route("login")]
        [ResponseType(typeof(UIKorisnik))]
        public IHttpActionResult Login(LoginVM model)
        {
            Korisnici k = FindUser(model.username, model.password);

            if (k == null)
                return NotFound();

            if (!k.Aktivan)
                return Unauthorized();

            string generated = Guid.NewGuid().ToString();
            AutorizacijskiToken autorizacijskiToken = new AutorizacijskiToken()
            {
                KorisnikId = k.Id,
                Vrijednost = generated,
                VrijemeEvidentiranja = DateTime.Now
            };

            db.AutorizacijskiToken.Add(autorizacijskiToken);
            db.SaveChanges();


            UIKorisnik result = new UIKorisnik()
            {
                KorisnikId = k.Id,
                Aktivan = k.Aktivan,
                AuthToken = generated,
                Email = k.Email,
                Ime = k.Ime,
                Prezime = k.Prezime,
                KorisnickoIme = k.KorisnickoIme,
                Slika = k.SlikaThumb
            };

            return Ok(result);
        }

        [HttpPost]
        [Route("loginwithtoken")]
        [ResponseType(typeof(UIKorisnik))]
        public IHttpActionResult LoginWithToken([FromBody] string authToken)
        {
            Korisnici k = FindByAuthToken(authToken);

            if (k == null)
                return NotFound();

            if (!k.Aktivan)
                return Unauthorized();

            UIKorisnik result = new UIKorisnik()
            {
                KorisnikId = k.Id,
                Aktivan = k.Aktivan,
                AuthToken = authToken,
                Email = k.Email,
                Ime = k.Ime,
                Prezime = k.Prezime,
                KorisnickoIme = k.KorisnickoIme,
                Slika = k.SlikaThumb
            };

            return Ok(result);
        }

        [HttpGet]
        [Route("ResetPassword/{username}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult ResetPassword(string username)
        {
            Korisnici k = db.Korisnici.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            if (k == null)
                return NotFound();

            try
            {
                var novaLozinka = System.Web.Security.Membership.GeneratePassword(10, 3);
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(k.LozinkaSalt, novaLozinka);
                db.ssp_Korisnici_Update(k.Id, k.Ime, k.Prezime, k.Email,
                       k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Aktivan, k.JMBG, k.DatumRodjenja.Value.Date);
                UIHelper.SendMail(k.Email, k.KorisnickoIme, novaLozinka, true);
            }
            catch (Exception)
            {
                return null;
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpGet]
        public IHttpActionResult Logout(string token)
        {
            AutorizacijskiToken AuthToken = db.AutorizacijskiToken.Where(x => x.Vrijednost == token).FirstOrDefault();
            if(AuthToken != null)
            {
                db.AutorizacijskiToken.Remove(AuthToken);
            }

            return Ok();
        }
        private Korisnici FindUser(string username, string password)
        {
            Korisnici k = db.Korisnici.Where(x => x.KorisnickoIme == username).Include(x => x.KorisniciUloge).FirstOrDefault();

            if (k == null)
                return null;

            if (Util.UIHelper.GenerateHash(k.LozinkaSalt, password) == k.LozinkaHash)
                return k;

            return null;
        }
        private Korisnici FindByAuthToken(string authToken)
        {
            AutorizacijskiToken token = db.AutorizacijskiToken.Where(x => x.Vrijednost == authToken)
                                                                .Include(x => x.Korisnici).FirstOrDefault();
            if (token == null)
                return null;
            
            return token.Korisnici;
        }



    }
}
