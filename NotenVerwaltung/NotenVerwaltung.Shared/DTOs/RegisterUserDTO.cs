using System.ComponentModel.DataAnnotations;

namespace NotenVerwaltung.Shared.DTOs;

public class RegisterUserDTO
{
    [Required]
    [EmailAddress]
    [RegularExpression(@"^[a-z]+\.[a-z]+@(gibz|zg)\.ch$", ErrorMessage = "Email must have this format example.example@gibz.ch or example.example@zg.ch")]
    public string Email { get; set; }

    [Required]
    [MinLength(6, ErrorMessage = "Password must be at least 6 character lenght")]
    public string Password { get; set; }

    [Required]
    [Compare("Password", ErrorMessage = "Password are not the same")]
    public string ConfirmPassword { get; set; }

    [Required]
    public string FullName { get; set; }
}
