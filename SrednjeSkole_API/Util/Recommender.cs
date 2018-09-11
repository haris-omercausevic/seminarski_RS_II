using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Util
{
    public class Recommender
    {
        private SrednjeSkoleEntities db = new SrednjeSkoleEntities(false);

        public List<Materijali_Result> GetMaterijaliPreporuka(int ucenikId, int razred)
        {
            List<Materijali_Result> najboljiMaterijaliRazreda = GetNajboljiMaterjialiRazreda(razred);
            List<Predmeti_Result> predmetiLosProsjek = db.ssp_UceniciOcjene_GetPredmetiByUcenikLosProsjek(razred, ucenikId).ToList();

            List<List<Korisnici_Result>> uceniciDobarProsjek = new List<List<Korisnici_Result>>();
            foreach (var item in predmetiLosProsjek)
                uceniciDobarProsjek.Add(db.ssp_UceniciOcjene_GetUceniciByPredmetProsjek(item.PredmetId).ToList());

            foreach (var item in uceniciDobarProsjek)
            {
                
            }



            return null;
        }

        public List<Materijali_Result> GetNajboljiMaterjialiRazreda(int razred, double brojOcjenaFaktor = 0.05, double ratingFaktor = 3)
        {
            return db.ssp_Materijali_GetByRazredPreporukaKonfigurabilna(razred, Convert.ToDecimal(brojOcjenaFaktor), Convert.ToDecimal(ratingFaktor)).ToList();
        }

    }
}