namespace NotenVerwaltung.Shared.DTOs;

public class SubjectDTO
{
    public int Id { get; set; }
    public string SubjectName { get; set; }
    public int TeacherId { get; set; }
    public TeacherDTO Teacher { get; set; }
    public int ProrectorId { get; set; }
    public ProrectorDTO Prorector { get; set; }
}
