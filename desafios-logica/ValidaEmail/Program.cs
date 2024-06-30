using System.Text.RegularExpressions;

Console.WriteLine("Registre um e-mail");
string email = Console.ReadLine();

if (IsValidEmail(email))
{
    Console.WriteLine("E-mail registrado.");
}
else
{
    Console.WriteLine("E-mail inválido.");
}

static bool IsValidEmail(string email)
{
    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$";
    Regex regex = new(pattern, RegexOptions.IgnoreCase);

    return regex.IsMatch(email);
}