using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IProrectorService
{
    public List<ProrectorDTO> GetAllProrectors();
}
