namespace NotenVerwaltung.Shared.DTOs;

public class TeacherDTO
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>
    /// The email.
    /// </value>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the subjects which the teacher teaches.
    /// </summary>
    /// <value>
    /// The subjects.
    /// </value>
    public List<SubjectDTO> Subjects { get; set; }
}
