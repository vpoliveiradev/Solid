namespace Solid._05_DIP.Bad;

public class EmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        // Code to send email
        Console.WriteLine($"Sending email to {to} with subject {subject}");
    }
}