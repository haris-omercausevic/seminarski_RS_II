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
    }
}
