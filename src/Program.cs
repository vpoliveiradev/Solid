using Solid._05_DIP.Good;
using Solid._05_DIP.Good.Mocks;

Console.WriteLine("Hello, World!");

//Consigo nos testes usar um FAKE ao invés de usar a implementação real e acabar enviando um email
// Isso é uma boa prática, pois não quero enviar emails reais durante os testes
FakeEmailService emailService = new FakeEmailService();
var usuarioService = new UsuarioService(emailService);

//Esse seria o código caso eu quisesse enviar um email real
EmailService emailServiceReal = new EmailService();
var usuarioServiceReal = new UsuarioService(emailServiceReal);