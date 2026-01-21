namespace NotenVerwaltung.Backend.Services;

public interface IEmailService
{
    /// <summary>
    /// Sends the asynchronous Email.
    /// </summary>
    /// <param name="to">To.</param>
    /// <param name="subject">The subject.</param>
    /// <param name="body">The body.</param>
    /// <returns>Task</returns>
    Task SendAsync(string to, string subject, string body);
}
