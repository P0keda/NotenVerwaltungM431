using NotenVerwaltung.Shared.DTOs;

namespace NotenVerwaltung.Backend.Services;

public interface IGradeService
{
    public List<GradeDTO> GetAllGrades();
}
