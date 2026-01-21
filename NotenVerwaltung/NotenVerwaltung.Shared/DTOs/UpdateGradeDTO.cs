namespace NotenVerwaltung.Shared.DTOs;

/// <summary>
/// DTO wich helps to update grade with changeRequest
/// </summary>
public class UpdateGradeDTO
{
    /// <summary>
    /// Gets or sets the grade value for update.
    /// </summary>
    /// <value>
    /// The grade value.
    /// </value>
    public decimal GradeValue { get; set; }

    /// <summary>
    /// Gets or sets the comment for update.
    /// </summary>
    /// <value>
    /// The comment.
    /// </value>
    public string Comment { get; set; }
}
