using System.Security.Cryptography;
using System.Text;

namespace TPL_Store.Models;

public class UserInformation
{
    public string Username { get; set; }
    public string PasswordHash { get; private set; }
    public byte[] Salt { get; private set; }

    public void SetPassword(string password)
    {
        using var rng = RandomNumberGenerator.Create();
        Salt = new byte[16];
        rng.GetBytes(Salt);

        PasswordHash = HashPassword(password, Salt);
    }

    public bool ValidatePassword(string password)
    {
        return PasswordHash == HashPassword(password, Salt);
    }

    private static string HashPassword(string password, byte[] salt)
    {
        using var sha256 = SHA256.Create();
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        var combined = new byte[salt.Length + passwordBytes.Length];

        salt.CopyTo(combined, 0);
        passwordBytes.CopyTo(combined, salt.Length);

        var hashBytes = sha256.ComputeHash(combined);
        return Convert.ToBase64String(hashBytes);
    }
}