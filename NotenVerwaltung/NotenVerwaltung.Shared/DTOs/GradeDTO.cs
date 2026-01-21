namespace NotenVerwaltung.Shared.DTOs;

public class GradeDTO
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the student identifier.
    /// </summary>
    /// <value>
    /// The student identifier.
    /// </value>
    public int StudentId { get; set; }

    /// <summary>
    /// Gets or sets the student.
    /// </summary>
    /// <value>
    /// The student.
    /// </value>
    public StudentDTO Student { get; set; }

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
    /// Gets or sets the subject identifier.
    /// </summary>
    /// <value>
    /// The subject identifier.
    /// </value>
    public int SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    /// <value>
    /// The subject.
    /// </value>
    public SubjectDTO Subject { get; set; }

    /// <summary>
    /// Gets or sets the grade value.
    /// </summary>
    /// <value>
    /// The grade value.
    /// </value>
    public decimal GradeValue { get; set; }

    /// <summary>
    /// Gets or sets the exam date.
    /// </summary>
    /// <value>
    /// The date of exam.
    /// </value>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    /// <value>
    /// The comment.
    /// </value>
    public string Comment { get; set; }
}
