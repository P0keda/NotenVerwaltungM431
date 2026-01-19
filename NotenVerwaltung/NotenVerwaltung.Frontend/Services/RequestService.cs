using NotenVerwaltung.Frontend.Models;
public class RequestService
{
    private readonly LocalStorageService storage;
    private const string StorageKey = "requests";

    public event Action? OnChange;

    public List<RequestModel> Requests { get; private set; } = new();

    public RequestService(LocalStorageService storage)
    {
        this.storage = storage;
    }

    public async Task InitializeAsync()
    {
        var saved = await storage.GetItemAsync<List<RequestModel>>(StorageKey);
        Requests = saved ?? new List<RequestModel>();
        OnChange?.Invoke();
    }

    public async Task AddRequest(RequestModel request)
    {
        Requests.Add(request);
        await storage.SetItemAsync(StorageKey, Requests);
        OnChange?.Invoke();
    }
}