Dictionary<int, string> usuarios = [];

usuarios.Add(74, "Lucas");
usuarios.Add(63, "Fábio");
usuarios.Add(84, "Kauã");

// Console.WriteLine($"Quantidade de Usuários: {usuarios.Count}\n");

// foreach (var item in usuarios)
// {
//     Console.WriteLine($"Chave - {item.Key} | Usuário - {item.Value}");
// }

int chave = 74;

try
{
    Console.WriteLine($"Usuário - {usuarios[chave]}");
}
catch
{
    throw new ArgumentException("Esta chave não está presente no banco de usuários.");
}
finally
{
    Console.WriteLine("Programa finalizado.");
}