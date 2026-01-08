using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface ITeacherRepository
{
    public List<Teacher> GetAllTeachers();

    public Teacher GetTeacherById(int id);

    public Teacher GetTeacherByEmail(string email);
}
