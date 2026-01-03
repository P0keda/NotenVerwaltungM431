using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IProrectorRepository
{
    public List<Prorector> GetAllProrectors();
    public Prorector GetProrectorById(int id);
}
