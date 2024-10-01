// File: PasswordManager/PasswordManager.cs

namespace PasswordManager.App
{
    public class PasswordManager
    {
        private readonly Dictionary<string, string> _passwords = new();

        public void AddPassword(string site, string password)
        {
            _passwords[site] = password;
        }

        public string GetPassword(string site)
        {
            _passwords.TryGetValue(site, out var password);
            return password ?? string.Empty;
        }
    }
}