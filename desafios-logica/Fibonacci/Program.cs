Console.WriteLine($"The first numbers of Fibonacci sequence:");

PrintFibonacciSequence(10);

static void PrintFibonacciSequence(int n) // n é o número de elemento que a função vai gerar
{
    int first = 0;
    int second = 1;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{first}");

        int next = first + second;
        first = second;
        second = next;
    }
}