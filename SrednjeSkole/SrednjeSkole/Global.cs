using System;
using System.Collections.Generic;
using System.Text;

using Plugin.Settings;
using Plugin.Settings.Abstractions;
using SrednjeSkole.Models;
namespace SrednjeSkole
{
    public class Global
    {
        public static UIKorisnik prijavljeniKorisnik { get; set; }
        public static string imeFajla { get; set; }
        private static ISettings AppSettings => CrossSettings.Current;

        public static string AuthToken
        {
            get => CrossSettings.Current.GetValueOrDefault(nameof(AuthToken), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AuthToken), value);
        }

        #region API Routes
        public const string AutentifikacijaRoute = "api/Autentifikacija";
        public const string KorisniciRoute = "api/Korisnici";
        public const string UceniciRoute = "api/Ucenici";
        public const string NastavniciRoute = "api/Nastavnici";
        public const string UlogeRoute = "api/Uloge";
        public const string PredmetiRoute = "api/Predmeti";
        public const string SmjeroviRoute = "api/Smjerovi";
        public const string RazrediRoute = "api/Razredi";
        public const string UceniciRazrediRoute = "api/UceniciRazredi";
        public const string SkolskeGodineRoute = "api/SkolskeGodine";
        public const string ObavijestiRoute = "api/Obavijesti";
        public const string PredajeRoute = "api/Predaje";
        public const string UceniciOcjeneRoute = "api/UceniciOcjene";
        public const string MaterijaliRoute = "api/Materijali";
        public const string BlobsRoute = "api/Blobs";

        #endregion
    }
}
