using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChangeRequestController : ControllerBase
{
    private readonly IChangeRequestService _changeRequestService;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeRequestController"/> class.
    /// </summary>
    /// <param name="changeRequestService">The change request service.</param>
    /// <param name="gradeService">The grade service.</param>
    public ChangeRequestController (IChangeRequestService changeRequestService, IGradeService gradeService)
    {
        _changeRequestService = changeRequestService;
    }

    /// <summary>
    /// Gets all change requests.
    /// </summary>
    /// <returns>ActionResult<List<ChangeRequestDTO>></returns>
    [HttpGet]
    public ActionResult<List<ChangeRequestDTO>> GetAllChangeRequests ()
    {
        return _changeRequestService.GetAllChangeRequest();
    }

    /// <summary>
    /// Gets the change request by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<ChangeRequestDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<ChangeRequestDTO> GetChangeRequestById(int id)
    {
        ChangeRequestDTO changeRequest = _changeRequestService.GetChangeRequestById(id);
        return Ok(changeRequest);
    }

    /// <summary>
    /// Creates the change request.
    /// </summary>
    /// <param name="createChangeRequest">The create change request.</param>
    /// <returns>ActionResult<ChangeRequestDTO></returns>
    [HttpPost]
    public ActionResult<ChangeRequestDTO> CreateChangeRequest([FromBody] CreateChangeRequestDTO createChangeRequest)
    {
        ChangeRequestDTO created = _changeRequestService.CreateChangeRequest(createChangeRequest);
        return CreatedAtAction(nameof(GetChangeRequestById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Updates the change request.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="updateChangeRequest">The update change request.</param>
    /// <returns>ActionResult<ChangeRequestDTO></returns>
    [HttpPut("{id}")]
    public ActionResult<ChangeRequestDTO> UpdateChangeRequest(int id, [FromBody] UpdateChangeRequestDTO updateChangeRequest)
    {
        ChangeRequestDTO updated = _changeRequestService.UpdateChangeRequestById(updateChangeRequest, id);
        return Ok(updated);
    }
}
