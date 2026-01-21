namespace NotenVerwaltung.Shared.DTOs;

public class ChangeRequestDTO
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the grade identifier.
    /// </summary>
    /// <value>
    /// The grade identifier.
    /// </value>
    public int GradeId { get; set; }

    /// <summary>
    /// Gets or sets the grade.
    /// </summary>
    /// <value>
    /// The grade.
    /// </value>
    public GradeDTO Grade { get; set; }

    /// <summary>
    /// Gets or sets the teacher identifier.
    /// </summary>
    /// <value>
    /// The teacher identifier.
    /// </value>
    public int TeacherId { get; set; }

    /// <summary>
    /// Gets or sets the teacher.
    /// </summary>
    /// <value>
    /// The teacher.
    /// </value>
    public TeacherDTO Teacher { get; set; }

    /// <summary>
    /// Gets or sets the prorector identifier.
    /// </summary>
    /// <value>
    /// The prorector identifier.
    /// </value>
    public int ProrectorId { get; set; }

    /// <summary>
    /// Gets or sets the prorector.
    /// </summary>
    /// <value>
    /// The prorector.
    /// </value>
    public ProrectorDTO Prorector { get; set; }

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

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>
    /// The status.
    /// </value>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the requested date.
    /// </summary>
    /// <value>
    /// The requested date.
    /// </value>
    public DateOnly RequestedDate { get; set; }

    /// <summary>
    /// Gets or sets the decision date.
    /// </summary>
    /// <value>
    /// The decision date.
    /// </value>
    public DateOnly? DecisionDate { get; set; }
}
