using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace SrednjeSkole_API.Util
{
    public class UIHelper
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public static void SendMail(string mailTo, string korisnickoIme, string lozinka, bool resetLozinka = false)
        {
            string mail = ConfigurationManager.AppSettings["Mail"];
            string mailpass = ConfigurationManager.AppSettings["MailPass"];

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(mail, mailpass);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(mail);
            mailMessage.To.Add(mailTo);
            if (!resetLozinka)
            {

            mailMessage.Body = $"<h3>Poštovani,</h3>" +
                               $"vaši pristupni podaci su: " +
                               $"<p>Korisničko ime: {korisnickoIme}</p>" +
                               $"<p>Lozinka: {lozinka}</p>" +
                               $"<p>========================</p>" +
                               $"<p>SrednjeSkoleApp</p>";
            }
            else
            {
                mailMessage.Body = $"<h3>Poštovani {korisnickoIme},</h3>" +
                               $"vaša nova lozinka je {lozinka}: " +
                               $"<p>========================</p>" +
                               $"<p>SrednjeSkoleApp</p>";
            }

            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = "SrednjeSkoleApp - Login podaci";
            client.Send(mailMessage);
        }
    }
}