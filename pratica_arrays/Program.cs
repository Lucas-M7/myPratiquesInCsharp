string[] nomesDosUsuarios = { "Lucas", "Edson", "Felipe", "Ítalo" };

int contador = 0;

foreach(string usuario in nomesDosUsuarios)
{
    Console.WriteLine($"Usuário N° {contador + 1} - {usuario}");
    contador++;
}