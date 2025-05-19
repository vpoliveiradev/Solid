namespace Solid._05_DIP.Good;

using Solid._05_DIP.Good.Interfaces;


public class UsuarioService(IEmailService emailService)
{
    private readonly IEmailService _emailService = emailService;

    public void RegisterUser(string email)
    {
        // Logic to register the user
        Console.WriteLine($"User {email} registered.");

        // Send a welcome email
        _emailService.SendEmail(email, "Welcome!", "Thank you for registering.");
    }
}