using NotenVerwaltung.Backend.Models;

namespace NotenVerwaltung.Backend.Repositories;

public class GradeRepository : IGradeRepository
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="GradeRepository"/> class.
    /// </summary>
    /// <param name="context">The context.</param>
    public GradeRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public List<Grade> GetAllGrades()
    {
        return _context.Grades.ToList();
    }

    /// <inheritdoc />
    public Grade GetGradeById(int id)
    {
        return _context.Grades.FirstOrDefault(g => g.Id == id);
    }

    /// <inheritdoc />
    public List<Grade> GetGradeByStudentId(int id)
    {
        return _context.Grades.Where(g => g.StudentId == id).ToList();
    }

    /// <inheritdoc />
    public List<Grade> GetGradeByStudentIdAndSubject(int StudentId, int subjectId)
    {
        return _context.Grades.Where(g => g.StudentId == StudentId && g.SubjectId == subjectId).ToList();
    }

    /// <inheritdoc />
    public Grade UpdateGrade(Grade updatedGrade, int id)
    {
        Grade existingGrade = _context.Grades.FirstOrDefault(g => g.Id == id);
        if (existingGrade == null)
        {
            return null;
        }
        existingGrade.Comment = updatedGrade.Comment;
        existingGrade.GradeValue = updatedGrade.GradeValue;
        _context.SaveChanges();
        return existingGrade;
    }
}
