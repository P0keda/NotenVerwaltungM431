using System.ComponentModel.DataAnnotations;

namespace NotenVerwaltung.Shared.DTOs;

public class LoginUserDTO
{
    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    [Required]
    [EmailAddress]
    [RegularExpression(@"^[a-z]+\.[a-z]+@(gibz|zg)\.ch$", ErrorMessage = "Email must have this format example.example@gibz.ch")]
    public string Email { get; set; }


    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>
    /// The password.
    /// </value>
    [Required (ErrorMessage = "Password is required, minimal lenght is 6 characters")]
    public string Password { get; set; }
}
