using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole
{
    public interface IHash
    {
        // login dependency injection
        string GenerateHash(string salt, string password);
    }
}
