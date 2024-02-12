// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"{10} x {i} = {i * 1}");
// }

string[] nomesDosUsuarios = { "Lucas", "Edson", "Felipe", "Ítalo" };

int contador = 0;

foreach(string usuario in nomesDosUsuarios)
{
    Console.WriteLine($"Usuário N° {contador + 1} - {usuario}");
    contador++;
}
