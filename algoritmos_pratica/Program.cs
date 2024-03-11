int[] myArr = [ 5, 332, -1, 0, 35 ];
int smallElement = SearchSmallestElement(myArr);

Console.WriteLine($"The small element of array is: {smallElement}");

static int SearchSmallestElement(int[] arr)
{
    if (arr.Length == 0)
    {
        throw new ArgumentException("The array can't null");
    }

    int small = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < small)
        {
            small = arr[i];
        }
    }

    return small;
}