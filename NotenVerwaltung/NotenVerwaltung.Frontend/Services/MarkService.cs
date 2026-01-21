using NotenVerwaltung.Shared.DTOs;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace NotenVerwaltung.Frontend.Services
{
    public class MarkService : IMarkService
    {
        private readonly HttpClient _http;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkService"/> class.
        /// </summary>
        /// <param name="http">The HTTP.</param>
        public MarkService(HttpClient http)
        {
            _http = http;
        }

        /// <inheritdoc />
        public async Task<List<GradeDTO>> GetAllGradesAsync()
        {
            return await _http.GetFromJsonAsync<List<GradeDTO>>("Grade");
        }

        /// <inheritdoc />
        public async Task<GradeDTO> GetGradeById(int id)
        {
            return await _http.GetFromJsonAsync<GradeDTO>($"Grade/{id}");
        }

        /// <inheritdoc />
        public async Task<List<GradeDTO>> GetGradesByStudentIdAsync(int studentId)
        {
            return await _http.GetFromJsonAsync<List<GradeDTO>>($"Grade/student/{studentId}");
        }
    }
}