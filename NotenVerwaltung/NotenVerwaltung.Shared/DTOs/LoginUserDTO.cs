using System.ComponentModel.DataAnnotations;

namespace NotenVerwaltung.Shared.DTOs;

public class LoginUserDTO
{
    [Required]
    [EmailAddress]
    [RegularExpression(@"^[a-z]+\.[a-z]+@(gibz|zg)\.ch$", ErrorMessage = "Email must have this format example@gibz.ch")]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}
