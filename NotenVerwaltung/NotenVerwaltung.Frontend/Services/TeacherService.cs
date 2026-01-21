using NotenVerwaltung.Shared.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services;


public class TeacherService : ITeacherService
{
    private readonly HttpClient _http;

    /// <summary>
    /// Initializes a new instance of the <see cref="TeacherService"/> class.
    /// </summary>
    /// <param name="http">The HTTP.</param>
    public TeacherService(HttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc />
    public async Task<List<TeacherDTO>> GetAllTeachersAsync()
    {
        return await _http.GetFromJsonAsync<List<TeacherDTO>>("Teacher");
    }

    /// <inheritdoc />
    public async Task<TeacherDTO?> GetTeacherByIdAsync(int id)
    {
        return await _http.GetFromJsonAsync<TeacherDTO>($"Teacher/{id}");
    }
}