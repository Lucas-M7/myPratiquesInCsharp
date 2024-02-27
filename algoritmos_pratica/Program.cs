static List<int> SomarListas(List<int> lista1, List<int> lista2)
{
    List<int> resultado = new List<int>();

    if (lista1.Count != lista2.Count)
    {
        throw new ArgumentException("Aí tem como não, fera");
    }

    for (int i = 0; i < lista1.Count; i++)
    {
        resultado.Add(lista1[i] + lista2[i]);
    }

    return resultado;
}

List<int> listaA = new List<int> {2, 3, 4, 5, 6};
List<int> listaB = new List<int> {2, 3, 4, 5, 6};

List<int> listaDeSoma = SomarListas(listaA, listaB);
Console.WriteLine($"Lista de Soma:");
foreach (int numero in listaDeSoma)
{
    Console.WriteLine(numero);
}

SomarListas(listaA, listaB);






















// string[] nomes =
// [
//     "Ana","Bruno",
//     "Clara","Daniel","Elisa", "Amanda", "Leonardo", "Felipe","Gabriela","Hugo","Ingrid","João","Kátia", "Luciano",
//     "Lucas","Marina","Nuno","Olívia","Pedro","Rita", "Fábio", "Sofia","Thiago","Vitória", "Fernando", "Leandro"
// ];

// static void ProcurarNomes(string[] nomes)
// {
//     var nomesComInicial = nomes.Where(n => n.StartsWith("L"));

//     if (nomesComInicial.Any())
//     {
//         foreach (string nome in nomesComInicial)
//         {
//             Console.WriteLine(nome);
//         }
//     }
//     else
//     {
//         Console.WriteLine($"Sei lá");
//     }
// }

// ProcurarNomes(nomes);
























// static void ObterMaiorEMenor(int[] lista)
// {
//     int menor = lista[0];

//     foreach (var numero in lista)
//     {
//         if (numero < menor)
//         {
//             menor = numero;
//         }
//     }

//     int maior = lista[0];

//     foreach (var numero in lista)
//     {
//         if (numero > maior)
//         {
//             maior = numero;
//         }
//     }

//     Console.WriteLine($"Maior elemento: {maior}");
//     Console.WriteLine($"Menor elemento: {menor}");
// }

// int[] numeros = [36, 41, 52, 72, 73];

// ObterMaiorEMenor(numeros);






// static void Fatorial(int numero)
// {
//     long resultado = 1;

//     for (int j = 2; j <= numero; j++)
//     {
//         Console.WriteLine($"Saída: {resultado *= j}");
//     }
// }

// Fatorial(5);











// static void meuNumero(int numero)
// {
//     for (int i = 1; i <= numero; i++)
//     {
//         Console.WriteLine($"-> {i}");
//     }

//     Console.WriteLine($"Seu número é o {numero}");
// }

// meuNumero(10000);



// static void meuNumero(int numero)
// {
//     string linha = "";

//     for (int i = 1; i <= numero; i++)
//     {
//         linha = linha + " " + numero;
//     }
//     for (int i = 1; i <= numero; i++)
//     {
//         Console.WriteLine($"{linha}");
//     }

//     Console.WriteLine($"Seu número é - {numero}");
// }

// meuNumero(7);