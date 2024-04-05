static int SquareSumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10; // The last digit extraction
        sum += digit * digit;
        number /= 10; // Remove the last digit
    }
    return sum;
}

static bool IsHappy(int number)
{
    HashSet<int> seen = [];
    while (number != 1 && !seen.Contains(number))
    {
        seen.Add(number);
        number = SquareSumOfDigits(number);
    }

    return number == 1;
}

int number = 19;
bool result = IsHappy(number);
Console.WriteLine($"The number {number} is {(result ? "happy" : "unhappy")}.");