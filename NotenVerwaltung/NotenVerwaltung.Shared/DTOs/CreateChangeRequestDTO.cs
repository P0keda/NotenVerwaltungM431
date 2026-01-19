namespace NotenVerwaltung.Shared.DTOs;

public class CreateChangeRequestDTO
{
    public int GradeId { get; set; }
    public int TeacherId { get; set; }
    public int ProrectorId { get; set; }
    public decimal RequestedValue { get; set; }
    public string Reason { get; set; }
}
