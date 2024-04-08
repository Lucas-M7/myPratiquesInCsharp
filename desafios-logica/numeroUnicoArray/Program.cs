static int SearchUniqueValueInArray(int[] numbers)
{
    int init = 0;

    foreach (int num in numbers)
    {
        init ^= num; // Operação XOR
    }

    return init;
}

int[] myArr = [4, 4, 73, 73, 7, 9, 0, 0, 9];
int uniqueNumber = SearchUniqueValueInArray(myArr);
Console.WriteLine($"The unique number in list is: {uniqueNumber}");