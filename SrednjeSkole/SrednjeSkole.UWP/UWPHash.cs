using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Xamarin.Forms;
using System.Runtime.InteropServices.WindowsRuntime;


[assembly: Dependency(typeof(SrednjeSkole.UWP.UWPHash))]
namespace SrednjeSkole.UWP
{
    public class UWPHash : IHash
    {
        public string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            IBuffer input = dst.AsBuffer();
            var hashAlgorithm = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha1);
            var hash = hashAlgorithm.HashData(input);

            return CryptographicBuffer.EncodeToBase64String(hash);
        }
    }
}
