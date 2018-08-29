using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Login
{
    internal class SeguridadLogin
    {
        public static string EncriptarPassword(string originalPassword)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha256.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }
    }
}
