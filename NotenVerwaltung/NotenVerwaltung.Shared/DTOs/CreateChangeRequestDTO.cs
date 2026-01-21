namespace NotenVerwaltung.Shared.DTOs;

public class CreateChangeRequestDTO
{
    /// <summary>
    /// Gets or sets the grade identifier.
    /// </summary>
    /// <value>
    /// The grade identifier.
    /// </value>
    public int GradeId { get; set; }

    /// <summary>
    /// Gets or sets the teacher identifier.
    /// </summary>
    /// <value>
    /// The teacher identifier.
    /// </value>
    public int TeacherId { get; set; }

    /// <summary>
    /// Gets or sets the prorector identifier.
    /// </summary>
    /// <value>
    /// The prorector identifier.
    /// </value>
    public int ProrectorId { get; set; }

    /// <summary>
    /// Gets or sets the requested value.
    /// </summary>
    /// <value>
    /// The requested value.
    /// </value>
    public decimal RequestedValue { get; set; }

    /// <summary>
    /// Gets or sets the reason.
    /// </summary>
    /// <value>
    /// The reason.
    /// </value>
    public string Reason { get; set; }
}
