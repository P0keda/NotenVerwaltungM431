using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface ITeacherRepository
{
    public List<Teacher> GetAll();
}
