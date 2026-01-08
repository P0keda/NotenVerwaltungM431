using Microsoft.JSInterop;
using System.Text.Json;

public class LocalStorageService
{
    private readonly IJSRuntime js;

    public LocalStorageService(IJSRuntime js)
    {
        this.js = js;
    }

    public async Task SetItemAsync<T>(string key, T value)
    {
        await js.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
    }

    public async Task<T?> GetItemAsync<T>(string key)
    {
        var json = await js.InvokeAsync<string>("localStorage.getItem", key);
        return json == null ? default : JsonSerializer.Deserialize<T>(json);
    }
}