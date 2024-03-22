List<int> numeros =[1, 2, 4, 8, 16, 24];

Console.WriteLine("Soma de todos os números pares da lista.\n");
foreach (var item in numeros)
{
    if (item % 2 == 0)
    {
        Console.WriteLine($"{item} + {item} = {item + item}");
    }
    else
    {
        Console.WriteLine($"O número {item} é ímpar.");
    }
}