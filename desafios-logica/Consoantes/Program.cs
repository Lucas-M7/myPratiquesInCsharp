Console.WriteLine("Writte anything:");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
string message = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

int vogals = 0;
int consonants = 0;

foreach (char c in message)
{
    if (char.IsLetter(c))
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            vogals++;
        else
            consonants++;
    }
}

Console.WriteLine($"Number of vogals: {vogals}");
Console.WriteLine($"Number of consonants: {consonants}");