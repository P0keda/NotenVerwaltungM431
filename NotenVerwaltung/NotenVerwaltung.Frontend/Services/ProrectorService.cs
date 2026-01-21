using NotenVerwaltung.Shared.DTOs;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services;

public class ProrectorService : IProrectorService
{
    private readonly HttpClient _http;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProrectorService"/> class.
    /// </summary>
    /// <param name="http">The HTTP.</param>
    public ProrectorService(HttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc />
    public async Task<List<ProrectorDTO>> GetAllProrectors()
    {
        return await _http.GetFromJsonAsync<List<ProrectorDTO>>("Prorector");
    }

    /// <inheritdoc />
    public async Task<ProrectorDTO> GetProrectorByEmail(string email)
    {
        return await _http.GetFromJsonAsync<ProrectorDTO>($"Prorector/email/{email}");
    }

    /// <inheritdoc />
    public async Task<ProrectorDTO> GetProrectorById(int id)
    {
        return await _http.GetFromJsonAsync<ProrectorDTO>($"Prorector/{id}");
    }
}
