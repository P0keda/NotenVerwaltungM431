namespace NotenVerwaltung.Backend.Models;

public class Subject
{
    public int Id { get; set; }
    public string SubjectName { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int ProrectorId { get; set; }
    public Prorector Prorector { get; set; }
}
