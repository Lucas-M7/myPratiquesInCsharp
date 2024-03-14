Queue<string> filaDoCaixa = new();

filaDoCaixa.Enqueue("Lucas");
filaDoCaixa.Enqueue("Fábio");
filaDoCaixa.Enqueue("Kauã");

var linha = string.Join(", ", filaDoCaixa);

Console.WriteLine($"\nQuantidade de pessoas na fila: {filaDoCaixa.Count}");
Console.WriteLine($"\nPessoas na fila: {linha}");

while (filaDoCaixa.Count > 0)
{
    Console.Write($"\nVez de: {filaDoCaixa.Peek()} - ");
    Console.WriteLine($"{filaDoCaixa.Dequeue()} atendido.");

    if (!filaDoCaixa.Contains("Kauã"))
    {
        Console.WriteLine("atendida. Na vdd");
    }
}