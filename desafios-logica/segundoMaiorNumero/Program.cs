static int GetTheSecondLargerValue(int[] myArr)
{
    int larger = int.MinValue;
    int secondLarger = int.MinValue;

    foreach (int item in myArr)
    {
        if (item > larger)
        {
            secondLarger = larger;
            larger = item;
        }
        else if (item > secondLarger)
        {
            secondLarger = larger;
        }
    }
    
    return secondLarger;
}

int[] arr = [674, 724, 3894, 91, 0, -2];
int secondLarger = GetTheSecondLargerValue(arr);
Console.WriteLine($"The second larger value in array is: {secondLarger}");