namespace Utils.Encryptor
{
    public interface IEncryptor
    {
        public string Encrypt(string password, string salt);
    }
}
