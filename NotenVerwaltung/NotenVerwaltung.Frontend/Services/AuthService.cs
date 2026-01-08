using System;
using System.Threading.Tasks;

namespace NotenVerwaltung.Frontend.Services
{
    public class AuthService
    {
        private readonly LocalStorageService storage;

        public bool IsAuthenticated { get; private set; } = false;
        public UserProfile CurrentUser { get; private set; } = new();
        public event Action? OnChange;

        public AuthService(LocalStorageService storage)
        {
            this.storage = storage;
        }

        // Wird beim App-Start aufgerufen
        public async Task InitializeAsync()
        {
            var savedUser = await storage.GetItemAsync<UserProfile>("user");

            if (savedUser != null)
            {
                CurrentUser = savedUser;
                IsAuthenticated = true;
            }

            NotifyStateChanged();
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            await Task.Delay(300);

            if (email.EndsWith("@gibz.ch") && password.Length >= 6)
            {
                CurrentUser = new UserProfile
                {
                    Name = email.Split('@')[0].Replace(".", " "),
                    Email = email,
                    Role = "Lehrperson"
                };

                IsAuthenticated = true;

                // User speichern
                await storage.SetItemAsync("user", CurrentUser);

                NotifyStateChanged();
                return true;
            }

            return false;
        }

        public async Task LogoutAsync()
        {
            IsAuthenticated = false;
            CurrentUser = new UserProfile();

            await storage.SetItemAsync<UserProfile>("user", null);

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

    public class UserProfile
    {
        public string Name { get; set; } = "Gast";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "Keine";
    }
}