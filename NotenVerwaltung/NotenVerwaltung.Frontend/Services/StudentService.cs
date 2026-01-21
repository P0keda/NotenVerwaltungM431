using NotenVerwaltung.Shared.DTOs;
using System.Net.Http.Json;

namespace NotenVerwaltung.Frontend.Services;

public class StudentService : IStudentService
{
    private readonly HttpClient _http;

    /// <summary>
    /// Initializes a new instance of the <see cref="StudentService"/> class.
    /// </summary>
    /// <param name="http">The HTTP.</param>
    public StudentService(HttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc />
    public async Task<List<StudentDTO>> GetAllAsync()
    {
        return await _http.GetFromJsonAsync<List<StudentDTO>>("Student");
    }

    /// <inheritdoc />
    public async Task<StudentDTO?> GetByIdAsync(int id)
    {
        return await _http.GetFromJsonAsync<StudentDTO>($"Student/{id}");
    }
}
