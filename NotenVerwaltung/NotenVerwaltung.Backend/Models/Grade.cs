namespace NotenVerwaltung.Backend.Models;

public class Grade
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student {get; set;}
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public decimal GradeValue { get; set; }
    public DateOnly GradeDate { get; set; }
    public string Comment { get; set; }
}
