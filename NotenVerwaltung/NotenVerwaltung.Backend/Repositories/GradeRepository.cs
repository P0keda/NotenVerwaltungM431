using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class GradeRepository : IGradeRepository
{
    private readonly AppDbContext _context;
    public GradeRepository(AppDbContext context)
    {
        _context = context;
    }
    public List<Grade> GetAllGrades()
    {
        return _context.Grades.ToList();
    }

    public Grade GetGradeById(int id)
    {
        return _context.Grades.FirstOrDefault(g => g.Id == id);
    }

    public List<Grade> GetGradeByStudentId(int id)
    {
        return _context.Grades.Where(g => g.StudentId == id).ToList();
    }

    public List<Grade> GetGradeByStudentIdAndSubject(int StudentId, int subjectId)
    {
        return _context.Grades.Where(g => g.StudentId == StudentId && g.SubjectId == subjectId).ToList();
    }
}
