Stack<string> pilhaDeLivros = new();

pilhaDeLivros.Push("Ultralearning");
pilhaDeLivros.Push("Clean Code");
pilhaDeLivros.Push("Clean Architecture");

Console.WriteLine($"\nQuantidade de Livros - {pilhaDeLivros.Count}");

var linha = string.Join(", ", pilhaDeLivros);
Console.WriteLine($"\nLivros - {linha}\n");