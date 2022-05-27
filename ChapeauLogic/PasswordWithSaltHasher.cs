using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauLogic
{
    public class PasswordWithSaltHasher
    {
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgorithm)
        {
            RandomNumberGeneratorHashSalt rng = new RandomNumberGeneratorHashSalt();
            byte[] saltBytes = rng.GeneratRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();

            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);

            byte[] hashBytes = hashAlgorithm.ComputeHash(passwordWithSaltBytes.ToArray());

            return new HashWithSaltResult(Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }
        public HashWithSaltResult HashWithSalt(string password, byte[] saltBytes, HashAlgorithm hashAlgorithm)
        {
            RandomNumberGeneratorHashSalt rng = new RandomNumberGeneratorHashSalt();
            //byte[] saltBytes = rng.GeneratRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();

            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);

            byte[] hashBytes = hashAlgorithm.ComputeHash(passwordWithSaltBytes.ToArray());

            return new HashWithSaltResult(Convert.ToBase64String(hashBytes), Convert.ToBase64String(saltBytes));
        }

        public HashWithSaltResult StringHasher(string hash, string salt)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            byte[] saltBytes = Encoding.ASCII.GetBytes(salt);
            int timesToHash = 99999;
            HashWithSaltResult hashWithSalt = pwHasher.HashWithSalt(hash, saltBytes, SHA512.Create());

            for (int i = 0; i < timesToHash; i++)
            {
                hashWithSalt = pwHasher.HashWithSalt(hashWithSalt.Hash, saltBytes, SHA512.Create());
            }
            return hashWithSalt;
        }
    }
}
