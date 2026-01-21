namespace NotenVerwaltung.Backend.Models;

public class Grade
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
    public Student Student {get; set;}

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
    public Teacher Teacher { get; set; }

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
    public Subject Subject { get; set; }

    /// <summary>
    /// Gets or sets the grade value.
    /// </summary>
    /// <value>
    /// The grade value.
    /// </value>
    public decimal GradeValue { get; set; }

    /// <summary>
    /// Gets or sets the grade date.
    /// </summary>
    /// <value>
    /// The grade date.
    /// </value>
    public DateOnly GradeDate { get; set; }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    /// <value>
    /// The comment.
    /// </value>
    public string Comment { get; set; }
}
