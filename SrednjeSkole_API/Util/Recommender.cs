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

            List<Predmeti_Result> predmetiLosProsjek = db.ssp_UceniciOcjene_GetPredmetiByUcenikLosProsjek(razred, ucenikId).ToList(); // top 3 predmeta gdje ima najlosiji prosjek

            if (predmetiLosProsjek.Count == 0) // ako nema ocjena
                return GetNajboljiMaterjialiRazreda(razred); // najbolji materijali u razredu koji je ucenik trenutno

            List<List<KorisniciSimple_Result>> uceniciDobarProsjek = new List<List<KorisniciSimple_Result>>(); // top 10 najboljih ucenika po prosjeku za svaki predmet iz predmetiLosProsjek
            foreach (var item in predmetiLosProsjek)
                uceniciDobarProsjek.Add(db.ssp_UceniciOcjene_GetUceniciByPredmetProsjek(item.PredmetId).ToList());


            Dictionary<int, OcjenaPredmet> materijaliOcjene = new Dictionary<int, OcjenaPredmet>(); // key = MaterijalId, value = OcjenaPredmet (cuva se predmetId i zbir ocjena)
                       

            foreach (var predmet in predmetiLosProsjek)
            {
                foreach (var listaUcenika in uceniciDobarProsjek)
                {
                    foreach (var ucenik in listaUcenika)
                    {
                        foreach (var ucenikMaterijalOcjena in db.ssp_MaterijaliOcjene_NajboljeOcijenjeniByUcenikPredmet(ucenik.Id, predmet.PredmetId).ToList()) //vraca top 5 ocijenjenih materijala za ucenika i predmet, sortirani po ocjeni pa po koeficijentu ((brojOcjena *0.05) + (rating * 3))
                        {
                            if (materijaliOcjene.ContainsKey(ucenikMaterijalOcjena.MaterijalId))
                                materijaliOcjene[ucenikMaterijalOcjena.MaterijalId]._ocjena += ucenikMaterijalOcjena.Ocjena; //ako je materijal vec u listi dodaj ocjenu u zbir
                            else
                            {
                                materijaliOcjene.Add(ucenikMaterijalOcjena.MaterijalId, new OcjenaPredmet()
                                {
                                    _materijalId = ucenikMaterijalOcjena.MaterijalId,
                                    _ocjena = ucenikMaterijalOcjena.Ocjena,
                                    _predmetId = predmet.PredmetId
                                }); // ako nije dodaj ga u dictionary
                            }
                        }
                    }
                }
            }

            List<Materijali_Result> materijaliZaPreporuku = new List<Materijali_Result>(); // za vratiti
            var materijaliPreporuka1 = new List<OcjenaPredmet>(); // najlosiji predmet
            var materijaliPreporuka2 = new List<OcjenaPredmet>(); // 2. najlosiji predmet
            var materijaliPreporuka3 = new List<OcjenaPredmet>(); // 3. najlosiji predmet


            for (int i = 0; i < predmetiLosProsjek.Count; i++) 
            {
                foreach (var item in materijaliOcjene) 
                {
                    if (i == 0 && item.Value._predmetId == predmetiLosProsjek[i].PredmetId)
                    {
                        materijaliPreporuka1.Add(new OcjenaPredmet()
                        {
                            _materijalId = item.Value._materijalId,
                            _ocjena = item.Value._ocjena,
                            _predmetId = item.Value._predmetId
                        });
                    }
                    else if (i == 1 && item.Value._predmetId == predmetiLosProsjek[i].PredmetId)
                    {
                        materijaliPreporuka2.Add(new OcjenaPredmet()
                        {
                            _materijalId = item.Value._materijalId,
                            _ocjena = item.Value._ocjena,
                            _predmetId = item.Value._predmetId
                        });
                    }
                    else if (i == 2 && item.Value._predmetId == predmetiLosProsjek[i].PredmetId)
                    {
                        materijaliPreporuka3.Add(new OcjenaPredmet()
                        {
                            _materijalId = item.Value._materijalId,
                            _ocjena = item.Value._ocjena,
                            _predmetId = item.Value._predmetId
                        });
                    }
                }
            }
            materijaliPreporuka1 = materijaliPreporuka1.OrderByDescending(x => x._ocjena).Take(3).ToList();//preuzmi prva 3 najbolje ocijenjena
            materijaliPreporuka2 = materijaliPreporuka2.OrderByDescending(x => x._ocjena).Take(3).ToList();
            materijaliPreporuka3 = materijaliPreporuka3.OrderByDescending(x => x._ocjena).Take(3).ToList();

            //get detalji materijala
            foreach (var item in materijaliPreporuka1)
                materijaliZaPreporuku.Add(db.ssp_Materijali_GetById(item._materijalId).FirstOrDefault());
            foreach (var item in materijaliPreporuka2)
                materijaliZaPreporuku.Add(db.ssp_Materijali_GetById(item._materijalId).FirstOrDefault());
            foreach (var item in materijaliPreporuka3)
                materijaliZaPreporuku.Add(db.ssp_Materijali_GetById(item._materijalId).FirstOrDefault());

            //prosjecan execution time je 2.7s :(
            //To Do: 
                //  optimizovati kod,  smanjiti broj petlji i poziva na bazu
                //  ako to ne pomogne puno:
                //  napraviti da se preporuka ucitava samo prvi put, i pohraniti listu materijala na disk, 
                //  i onda tek kada se uceniku unese ocjena iz nekog predmeta osjveziti preporuku

            return materijaliZaPreporuku;
        }

        class OcjenaPredmet
        {
            public int _materijalId { get; set; }
            public int _predmetId { get; set; }
            public int _ocjena { get; set; }
        }

        public List<Materijali_Result> GetNajboljiMaterjialiRazreda(int razred, double brojOcjenaFaktor = 0.05, double ratingFaktor = 3)
        {
            return db.ssp_Materijali_GetByRazredPreporukaKonfigurabilna(razred, Convert.ToDecimal(brojOcjenaFaktor), Convert.ToDecimal(ratingFaktor)).ToList();
        }

    }
}