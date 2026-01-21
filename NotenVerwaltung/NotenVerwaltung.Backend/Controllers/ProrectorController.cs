using Microsoft.AspNetCore.Mvc;
using NotenVerwaltung.Backend.Services;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProrectorController : ControllerBase
{
    private readonly IProrectorService _prorectorService;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProrectorController"/> class.
    /// </summary>
    /// <param name="prorectorService">The prorector service.</param>
    public ProrectorController(IProrectorService prorectorService)
    {
        _prorectorService = prorectorService;
    }

    /// <summary>
    /// Gets all prorectors.
    /// </summary>
    /// <returns>ActionResult<List<ProrectorDTO>></returns>
    [HttpGet]
    public ActionResult<List<ProrectorDTO>> GetAllProrectors()
    {
        return _prorectorService.GetAllProrectors();
    }

    /// <summary>
    /// Gets the prorector by identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult<ProrectorDTO></returns>
    [HttpGet("{id}")]
    public ActionResult<ProrectorDTO> GetProrectorById(int id)
    {
        return _prorectorService.GetProrectorById(id);
    }

    /// <summary>
    /// Gets the prorector by email.
    /// </summary>
    /// <param name="email">The email.</param>
    /// <returns>ActionResult<ProrectorDTO></returns>
    [HttpGet("email/{email}")]
    public ActionResult<ProrectorDTO> GetProrectorByEmail(string email)
    {
        return _prorectorService.GetProrectorByEmail(email);
    }
}
