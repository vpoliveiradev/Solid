namespace Solid._05_DIP.Good.Interfaces;

public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}