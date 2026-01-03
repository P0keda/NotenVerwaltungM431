namespace NotenVerwaltung.Shared.DTOs;

public class GradeDTO
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public StudentDTO Student { get; set; }
    public int TeacherId { get; set; }
    public TeacherDTO Teacher { get; set; }
    public int SubjectId { get; set; }
    public SubjectDTO Subject { get; set; }
    public decimal GradeValue { get; set; }
    public DateOnly Date { get; set; }
    public string Comment { get; set; }
}
