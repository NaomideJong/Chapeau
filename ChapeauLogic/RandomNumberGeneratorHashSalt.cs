using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class RandomNumberGeneratorHashSalt
    {
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GeneratRandomCryptographicBytes(keyLength));
        }

        public byte[] GeneratRandomCryptographicBytes(int keyLength)
        {
            RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[keyLength];
            rNGCryptoServiceProvider.GetBytes(randomBytes);
            return randomBytes;
        }
    }
}
