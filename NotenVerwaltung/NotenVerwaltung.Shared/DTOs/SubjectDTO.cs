namespace NotenVerwaltung.Shared.DTOs;

public class SubjectDTO
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the subject.
    /// </summary>
    /// <value>
    /// The name of the subject.
    /// </value>
    public string SubjectName { get; set; }

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
}
