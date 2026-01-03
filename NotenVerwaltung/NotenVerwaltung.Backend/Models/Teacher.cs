using System.ComponentModel.DataAnnotations.Schema;

namespace NotenVerwaltung.Backend.Models;

[Table("teachers")]
public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}
