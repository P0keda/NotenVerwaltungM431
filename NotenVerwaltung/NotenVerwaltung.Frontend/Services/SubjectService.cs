using NotenVerwaltung.Shared.DTOs;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services;

public class SubjectService : ISubjectService
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectService"/> class.
    /// </summary>
    /// <param name="httpClient">The HTTP client.</param>
    public SubjectService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <inheritdoc />
    public async Task<List<SubjectDTO>> GetAllSubjects()
    {
        return await _httpClient.GetFromJsonAsync<List<SubjectDTO>>("Subject");
    }

    /// <inheritdoc />
    public async Task<SubjectDTO> GetSubjectById(int id)
    {
        return await _httpClient.GetFromJsonAsync<SubjectDTO>($"Subject/{id}");
    }
}
