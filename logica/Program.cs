// Fáceis

// Soma de Dois Números

// static void Somar(int a, int b)
// {
//     Console.WriteLine($"O resultado da soma de {a} + {b}: {a + b}");
// }

// Somar(4, 6);


// Conversão de Celsius para Fahrenheit

// static void Converter(int celsius)
// {
//     Console.WriteLine($"A conversão de {celsius} para F é: {(celsius * 1.8) + 32}");
// }

// Converter(39);


// Identificando o Maior Número

// static void MaiorNumero(int n1, int n2, int n3)
// {
//     if (n1 > n2 && n1 > n3)
//     {
//         Console.WriteLine($"O maior número é: {n1}");
//     }
//     else if (n2 > n1 && n2 > n3)
//     {
//         Console.WriteLine($"O maior número é: {n2}");
//     }
//     else
//     {
//         Console.WriteLine($"O maior número é {n3}");
//     }
// }

// MaiorNumero(4, 4728, 91939);

// Calculadora da Idade

static void CalcularIdade(int anoDeNascimento, int anoAtual)
{
    int calc = anoDeNascimento - anoAtual;
    Console.WriteLine($"Você tem {calc} anos!!");
}

CalcularIdade(2005, 2024);