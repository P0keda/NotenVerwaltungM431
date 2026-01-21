namespace NotenVerwaltung.Shared.DTOs;

/// <summary>
/// DTO which helps to change Status of changeRequest
/// </summary>
public class UpdateChangeRequestDTO
{
    /// <summary>
    /// Gets or sets the status of changeRequestDTO.
    /// </summary>
    /// <value>
    /// Enum status.
    /// </value>
    public RequestStatus Status { get; set; }
}
