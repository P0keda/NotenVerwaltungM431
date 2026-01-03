using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public interface IStudentRepository
{
    public List<Student> GetAllStudents();
    public Student GetStudentById(int id);
}
