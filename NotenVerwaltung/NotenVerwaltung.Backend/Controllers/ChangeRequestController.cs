using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChangeRequestController : ControllerBase
{
    private readonly IChangeRequestService _changeRequestService;

    public ChangeRequestController (IChangeRequestService changeRequestService)
    {
        _changeRequestService = changeRequestService;
    }

    [HttpGet]
    public ActionResult<List<ChangeRequestDTO>> GetAllChangeRequests ()
    {
        return _changeRequestService.GetAllChangeRequest();
    }
}
