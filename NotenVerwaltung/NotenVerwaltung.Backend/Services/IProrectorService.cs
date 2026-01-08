using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IProrectorService
{
    public List<ProrectorDTO> GetAllProrectors();
    public ProrectorDTO GetProrectorById(int id);
    public ProrectorDTO GetProrectorByEmail(string email);
}
