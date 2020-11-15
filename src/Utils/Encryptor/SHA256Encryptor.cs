using System;
using System.Security.Cryptography;
using System.Text;

namespace Utils.Encryptor
{
    public class SHA256Encryptor : IEncryptor
    {
        public string Encrypt(string password, string salt)
        {
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            return Convert.ToBase64String(hash); 
        }
    }
}
