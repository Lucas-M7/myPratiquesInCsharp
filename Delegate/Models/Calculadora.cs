namespace Delegate.Models;
public class Calculadora
{
    public static void Somar(int x, int y)
    {
        Console.WriteLine($"Adição: {x + y}");
    }

    public static void Quadrado(int x)
    {
        Console.WriteLine($"Quadrado: {x * x}");
    }
}