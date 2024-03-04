// Criando um dicionário para representar a tabela hash
Dictionary<string, int> cestoFrutas = new Dictionary<string, int>();

// Adicionando algumas frutas e suas quantidades ao dicionário
cestoFrutas["Maçã"] = 5;
cestoFrutas["Banana"] = 3;
cestoFrutas["Laranja"] = 2;

// Acessando a quantidade de frutas no cesto
Console.WriteLine($"Quantidade de maçãs: {cestoFrutas["Maçã"]}");
Console.WriteLine($"Quantidade de bananas: {cestoFrutas["Banana"]}");
Console.WriteLine($"Quantidade de laranjas: {cestoFrutas["Laranja"]}");

// Verificando se uma fruta específica está no cesto
string fruta = "Banana";
if (cestoFrutas.ContainsKey(fruta))
{
    Console.WriteLine($"{fruta} está no cesto de frutas.");
}
else
{
    Console.WriteLine($"{fruta} não está no cesto de frutas.");
}