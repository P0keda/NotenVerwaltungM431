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
    public ChangeRequestController (IChangeRequestService changeRequestService, IGradeService gradeService)
    {
        _changeRequestService = changeRequestService;
    }

    [HttpGet]
    public ActionResult<List<ChangeRequestDTO>> GetAllChangeRequests ()
    {
        return _changeRequestService.GetAllChangeRequest();
    }

    [HttpGet("{id}")]
    public ActionResult<ChangeRequestDTO> GetChangeRequestById(int id)
    {
        ChangeRequestDTO changeRequest = _changeRequestService.GetChangeRequestById(id);
        return Ok(changeRequest);
    }

    [HttpPost]
    public ActionResult<ChangeRequestDTO> CreateChangeRequest([FromBody] CreateChangeRequestDTO createChangeRequest)
    {
        ChangeRequestDTO created = _changeRequestService.CreateChangeRequest(createChangeRequest);
        return CreatedAtAction(nameof(GetChangeRequestById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public ActionResult<ChangeRequestDTO> UpdateChangeRequest(int id, [FromBody] UpdateChangeRequestDTO updateChangeRequest)
    {
        ChangeRequestDTO updated = _changeRequestService.UpdateChangeRequestById(updateChangeRequest, id);
        return Ok(updated);
    }
}
