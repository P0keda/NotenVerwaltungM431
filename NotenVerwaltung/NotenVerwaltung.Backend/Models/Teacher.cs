using System.ComponentModel.DataAnnotations.Schema;

namespace NotenVerwaltung.Backend.Models;

[Table("teachers")]
public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
