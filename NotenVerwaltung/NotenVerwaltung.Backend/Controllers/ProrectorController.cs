using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProrectorController : ControllerBase
{
    private readonly IProrectorService _prorectorService;

    public ProrectorController(IProrectorService prorectorService)
    {
        _prorectorService = prorectorService;
    }

    [HttpGet]
    public ActionResult<List<ProrectorDTO>> GetAllProrectors()
    {
        return _prorectorService.GetAllProrectors();
    }
}
