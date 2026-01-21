using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class ProrectorService : IProrectorService
{
    private readonly IProrectorRepository _prorectorRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProrectorService"/> class.
    /// </summary>
    /// <param name="prorectorRepository">The prorector repository.</param>
    public ProrectorService(IProrectorRepository prorectorRepository)
    {
        _prorectorRepository = prorectorRepository;
    }

    /// <inheritdoc />
    public List<ProrectorDTO> GetAllProrectors()
    {
        List<Prorector> prorectors = _prorectorRepository.GetAllProrectors();
        
        List<ProrectorDTO> prorectorsToReturn = new List<ProrectorDTO>();

        foreach (Prorector prorector in prorectors)
        {
            ProrectorDTO prorectorDTO = GetProrectorById(prorector.Id);
            prorectorsToReturn.Add(prorectorDTO);
        }
        return prorectorsToReturn;
    }

    /// <inheritdoc />
    public ProrectorDTO GetProrectorById(int id)
    {
        Prorector prorector = _prorectorRepository.GetProrectorById(id);

        ProrectorDTO prorectorDTO = new ProrectorDTO
        {
            Id = prorector.Id,
            Name = prorector.fullName,
            Department = prorector.Department,
            Email = prorector.Email,
        };

        return prorectorDTO;
    }

    /// <inheritdoc />
    public ProrectorDTO GetProrectorByEmail(string email)
    {
        Prorector prorector = _prorectorRepository.GetProrectorByEmail(email);
        ProrectorDTO prorectorDTO = new ProrectorDTO
        {
            Id = prorector.Id,
            Name = prorector.fullName,
            Department = prorector.Department,
            Email = prorector.Email,
        };
        return prorectorDTO;
    }
}
