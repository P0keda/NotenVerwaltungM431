namespace NotenVerwaltung.Backend.Models;

public class Student
{

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the full name.
    /// </summary>
    /// <value>
    /// The full name.
    /// </value>
    public string fullName { get; set; }

    /// <summary>
    /// Gets or sets the name of the class.
    /// </summary>
    /// <value>
    /// The name of the class.
    /// </value>
    public string className { get; set; }
}
