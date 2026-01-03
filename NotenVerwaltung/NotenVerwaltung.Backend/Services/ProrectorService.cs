using NotenVerwaltung.Backend.Models;
using NotenVerwaltung.Backend.Repositories;
using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public class ProrectorService : IProrectorService
{
    private readonly IProrectorRepository _prorectorRepository;

    public ProrectorService(IProrectorRepository prorectorRepository)
    {
        _prorectorRepository = prorectorRepository;
    }
    public List<ProrectorDTO> GetAllProrectors()
    {
        List<Prorector> prorectors = _prorectorRepository.GetAllProrectors();
        
        List<ProrectorDTO> prorectorsToReturn = new List<ProrectorDTO>();

        foreach (Prorector prorector in prorectors)
        {
            ProrectorDTO prorectorDTO = new ProrectorDTO
            {
                Id = prorector.Id,
                Name = prorector.fullName,
                Department = prorector.Department,
                Email = prorector.Email,
                Password = prorector.Password
            };
            prorectorsToReturn.Add(prorectorDTO);
        }
        return prorectorsToReturn;
    }
}
