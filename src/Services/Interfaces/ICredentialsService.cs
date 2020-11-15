namespace Services
{
    public interface ICredentialsService
    {
        string HashPassword(string password, out string salt);
        bool VerifyPassword(string password, string salt, string hash);
    }
}