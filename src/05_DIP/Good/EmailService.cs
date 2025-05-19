namespace Solid._05_DIP.Good;

using Solid._05_DIP.Good.Interfaces;

public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Code to send email
        Console.WriteLine($"Sending email to {to} with subject {subject}");
    }
}