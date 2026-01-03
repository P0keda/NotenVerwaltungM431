using NotenVerwaltung.Shared.DTOs;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotenVerwaltung.Backend.Models;

[Table("gradechangerequests")]
public class ChangeRequest
{
    public int Id { get; set; }
    public int GradeId { get; set; }
    public Grade Grade { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int ProrectorId { get; set; }
    public Prorector Prorector { get; set; }
    public decimal RequestedValue { get; set; }
    public string Reason { get; set; }
    public RequestStatus Status { get; set; }
    public DateOnly RequestDate { get; set; }
    public DateOnly? DecisionDate { get; set; }
}
