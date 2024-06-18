using System.Text;

Console.WriteLine("Seja bem vindo/a ao PassWorld!");

Console.WriteLine("Digite o comprimento da senha a ser criada.");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Deseja incluir letras maiúsculas? (s/n): ");
bool includeUppercase = Console.ReadLine()?.ToLower() == "s";

Console.WriteLine("Deseja incluir letras minúsculas? (s/n): ");
bool includeLowercase = Console.ReadLine()?.ToLower() == "s";

Console.WriteLine("Deseja incluir números? (s/n)");
bool includeNumbers = Console.ReadLine()?.ToLower() == "s";

Console.WriteLine("Deseja incluir caracteres especiais? (s/n)");
bool includeSpecial = Console.ReadLine()?.ToLower() == "s";

string password = GeneratePassword(length, includeUppercase, includeLowercase, includeNumbers, includeSpecial);

Console.WriteLine($"Senha gerada: {password}");

static string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecial)
{
    const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    const string numbersChars = "1234567890";
    const string specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";

    StringBuilder allowedChars = new();

    if (includeUppercase)
        allowedChars.Append(uppercaseChars);

    if (includeLowercase)
        allowedChars.Append(lowercaseChars);

    if (includeNumbers)
        allowedChars.Append(numbersChars);

    if (includeSpecial)
        allowedChars.Append(specialChars);

    if (allowedChars.Length == 0)
        throw new ArgumentException("Pelo menos um tipo de caractere deve ser selecionado.");

    StringBuilder password = new();
    Random random = new();

    for (int i = 0; i < length; i++)
    {
        int index = random.Next(allowedChars.Length);
        password.Append(allowedChars[index]);
    }

    return password.ToString();
}