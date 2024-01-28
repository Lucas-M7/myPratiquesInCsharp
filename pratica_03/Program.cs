using pratica_03.Interfaces;
using pratica_03.Models;

ICalculadora calc = new Calculadora();

Console.WriteLine($"O resultado de 5 + 5 é: {calc.Somar(5, 5)}");
Console.WriteLine($"O resultado de 5 - 5 é: {calc.Subtrair(5, 5)}");
Console.WriteLine($"O resultado de 5 * 5 é: {calc.Multiplicar(5, 5)}");
Console.WriteLine($"O resultado de 5 / 5 é: {calc.Dividir(5, 5)}");