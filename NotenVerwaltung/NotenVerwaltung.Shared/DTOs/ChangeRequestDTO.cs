namespace NotenVerwaltung.Shared.DTOs;

public class ChangeRequestDTO
{
    public int Id { get; set; }
    public int GradeId { get; set; }
    public GradeDTO Grade { get; set; }
    public int TeacherId { get; set; }
    public TeacherDTO Teacher { get; set; }
    public int ProrectorId { get; set; }
    public ProrectorDTO Prorector { get; set; }
    public decimal RequestedValue { get; set; }
    public string Reason { get; set; }
    public RequestStatus Status { get; set; }
    public DateOnly RequestedDate { get; set; }
    public DateOnly? DecisionDate { get; set; }
}
