using System.Security.Cryptography;


namespace NotenVerwaltung.Backend.Services;

/// <summary>
/// class which helps to convert normal string password into hash and salt
/// </summary>
public class PasswordHasher
{

    /// <summary>
    /// Creates the password hash.
    /// </summary>
    /// <param name="password">The password.</param>
    /// <param name="hash">The hash.</param>
    /// <param name="salt">The salt.</param>
    public static void CreatePasswordHash(string password, out byte[] hash, out byte[] salt)
    {
        using var hmac = new HMACSHA512();
        salt = hmac.Key;
        hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    }

    /// <summary>
    /// Verifies the password.
    /// </summary>
    /// <param name="password">The password.</param>
    /// <param name="storedHash">The stored hash.</param>
    /// <param name="storedSalt">The stored salt.</param>
    /// <returns></returns>
    public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
    {
        using var hmac = new HMACSHA512(storedSalt);
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return computedHash.SequenceEqual(storedHash);
    }
}
