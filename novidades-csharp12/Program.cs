int[] numeros1 = [1, 2, 3];
int[] numeros2 = [4, 5, 6];
int[] numeros3 = [7, 8, 9];

int[] juntando = [.. numeros1, .. numeros2, .. numeros3];
foreach (var item in juntando)
{
    Console.WriteLine(item);
}