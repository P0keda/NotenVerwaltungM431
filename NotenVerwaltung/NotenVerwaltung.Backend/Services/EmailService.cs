using System.Net;
using System.Net.Mail;

namespace NotenVerwaltung.Backend.Services;

public class EmailService : IEmailService
{
    private readonly SmtpClient _smtp;
    private readonly string _from;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmailService"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    public EmailService(IConfiguration configuration)
    {
        _from = configuration["Email:from"];

        _smtp = new SmtpClient(configuration["Email:Smtp"])
        {
            Port = int.Parse(configuration["Email:Port"]),
            Credentials = new NetworkCredential(
                configuration["Email:Username"],
                configuration["Email:Password"]
                ),
            EnableSsl = true
        };
    }

    /// <inheritdoc />
    public async Task SendAsync(string to, string subject, string body)
    {
        var message = new MailMessage(_from, to, subject, body);
        await _smtp.SendMailAsync(message);
    }
}
