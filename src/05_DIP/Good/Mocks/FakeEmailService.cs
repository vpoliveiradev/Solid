namespace Solid._05_DIP.Good.Mocks;

using Solid._05_DIP.Good.Interfaces;

public class FakeEmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Simulate sending an email
        Console.WriteLine($"Fake email sent to {to} with subject '{subject}' and body '{body}'");
    }
}