namespace Solid._05_DIP.Bad;

public class UserService(EmailService emailService)
{
    private readonly EmailService _emailService = emailService;

    public void RegisterUser(string email)
    {
        // Code to register user
        Console.WriteLine($"Registering user with email: {email}");

        // Send confirmation email
        _emailService.SendEmail(email, "Welcome!", "Thank you for registering.");
    }
}