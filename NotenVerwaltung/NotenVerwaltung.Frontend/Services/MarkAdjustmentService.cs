using NotenVerwaltung.Shared.DTOs;
using System.Net.Http.Json;

namespace NotenVerwaltung.Frontend.Services;

public class MarkAdjustmentService : IMarkAdjustmentService
{
    private readonly HttpClient _http;

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkAdjustmentService"/> class.
    /// </summary>
    /// <param name="http">The HTTP.</param>
    public MarkAdjustmentService(HttpClient http)
    {
        _http = http;
    }

    /// <inheritdoc />
    public async Task CreateChangeRequest(CreateChangeRequestDTO newchangeRequest)
    {
        await _http.PostAsJsonAsync("ChangeRequest", newchangeRequest);
    }

    /// <inheritdoc />
    public async Task<List<ChangeRequestDTO>> GetAllChangeRequests()
    {
        return await _http.GetFromJsonAsync<List<ChangeRequestDTO>>("ChangeRequest");
    }

    /// <inheritdoc />
    public async Task<ChangeRequestDTO> GetChangeRequestById(int id)
    {
        return await _http.GetFromJsonAsync<ChangeRequestDTO>($"ChangeRequest/{id}");
    }

    /// <inheritdoc />
    public async Task<UpdateChangeRequestDTO> UpdateChangeRequestById(UpdateChangeRequestDTO updatedChangeRequest, int id)
    {
        var response = await _http.PutAsJsonAsync($"ChangeRequest/{id}", updatedChangeRequest);

        if (!response.IsSuccessStatusCode) 
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<UpdateChangeRequestDTO>();
    }
}
