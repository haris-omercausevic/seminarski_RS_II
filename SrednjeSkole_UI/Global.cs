using SrednjeSkole_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrednjeSkole_UI
{
    public static class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }
        public static int brojUloga = 0;

        public const string BlobStorageUrl = "http://srednjeskole.blob.core.windows.net/srednjeskole/";
        public const string BlobContainer = "srednjeskole";
        public const string connString = "DefaultEndpointsProtocol=https;AccountName=srednjeskole;AccountKey=9JzTotn+UyfgAW9KVKHm2oDrF1dawMOLkARlYP/vKlfOEpYrZx8hJRF/sPnkz7gYwjS7DLFqgOq1NxcBU+Spkg==;EndpointSuffix=core.windows.net";

        #region API Routes
        public const string AutentifikacijaRoute = "api/Autentifikacija";
        public const string KorisniciRoute = "api/Korisnici";
        public const string UceniciRoute = "api/Ucenici";
        public const string NastavniciRoute = "api/Nastavnici";
        public const string UlogeRoute = "api/Uloge";
        public const string PredmetiRoute = "api/Predmeti";
        public const string SmjeroviRoute= "api/Smjerovi";
        public const string RazrediRoute = "api/Razredi";
        public const string UceniciRazrediRoute = "api/UceniciRazredi";
        public const string SkolskeGodineRoute = "api/SkolskeGodine";
        public const string ObavijestiRoute = "api/Obavijesti";
        public const string PredajeRoute = "api/Predaje";
        public const string UceniciOcjeneRoute = "api/UceniciOcjene";
        public const string MaterijaliRoute = "api/Materijali";
        public const string BlobsRoute = "api/Blobs";
        public const string NotifikacijeRoute = "api/Notifikacije";
        #endregion
    }
}
