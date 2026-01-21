namespace NotenVerwaltung.Backend.Models;

public class Prorector
{

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the full name.
    /// </summary>
    /// <value>
    /// The full name.
    /// </value>
    public string fullName { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the password hash.
    /// </summary>
    /// <value>
    /// The password hash.
    /// </value>
    public byte[] PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the password salt.
    /// </summary>
    /// <value>
    /// The password salt.
    /// </value>
    public byte[] PasswordSalt { get; set; }

    /// <summary>
    /// Gets or sets the department.
    /// </summary>
    /// <value>
    /// The department.
    /// </value>
    public string Department { get; set; }
}
