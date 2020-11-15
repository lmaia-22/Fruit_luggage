using Utils;
using Utils.Encryptor;

namespace Services
{
    public class CredentialsService : ICredentialsService
    {
        private readonly IEncryptor _encryptor;

        public CredentialsService(IEncryptor encryptor)
        {
            _encryptor = encryptor;
        }

        public string HashPassword(string password, out string salt)
        {
            salt = GenerateSalt();

            return _encryptor.Encrypt(password, salt);
        }

        public bool VerifyPassword(string password, string salt, string hash)
        {
            var encryptedHash = _encryptor.Encrypt(password, salt);

            return encryptedHash == hash;
        }

        private string GenerateSalt()
        {
            return SaltGenerator.GenerateRandomCryptographicKey();
        }
    }
}
