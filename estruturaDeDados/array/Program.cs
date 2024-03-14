using array.Colecoes.Helper;

OperacoesArray operacao = new();

int[] myArr = [6, -3, 1, 8, 13];

Console.WriteLine("\nArray original");
operacao.ImprimirArray(myArr);

operacao.OrdenarBubbleSort(myArr);

Console.WriteLine("\n Array ordenado");
operacao.ImprimirArray(myArr);



























//  Declara um array unidimensional de 5 elementos

int[] array1 = new int[5];

// Declara um array com a quantidade elementos que você por
int[] array2 = [1, 3, 5, 6, 2];

// Declara um array bidimensional
int[,] multiDimensionalArray1 = new int[2, 3];

// Declara e cria um array com seus elementos
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Declara um array irregular
int[][] jaggedArray = new int[7][];

// Cria os valores do primeiro array em uma estrutura de array irregular
jaggedArray[0] = [1, 2, 3, 4, 5];


// Mais sobre array unidimensional
string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

foreach (var dias in weekDays)
{
    // Console.WriteLine(dias); // Percorrendo o array
}



// static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(", ", arr));




// // Muda o array para reverter os elementos
// static void ChangeArray(string[] arr) => Array.Reverse(arr);

//  DisplayArray(weekDays);
//  Console.WriteLine();

//  // Reverte o array
//  ChangeArray(weekDays);
//  Console.WriteLine("Array weekDays depois de chamar o método ChangeArray:\n");
//  DisplayArray(weekDays);
//  Console.WriteLine();

// int[] numbers = [10, 4, 5, 3, 1, 2];
// Console.WriteLine(Array.IndexOf(numbers, 5));

int[,] arr2D = new int[4, 2];

int[,] arr2DInView = { {1, 2}, {2, 3}, {4, 5}, {6, 7} };

// Console.WriteLine(arr2DInView[1, 0]);


int[] numeros = [5, 2, 4, 1];
foreach (var numero in numeros)
{
    // Console.WriteLine(numero); // Saída: 5, 2, 4, 1
}