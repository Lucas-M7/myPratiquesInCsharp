Console.WriteLine("Enter a number for calculate the sum of digits of your factorial:");
int number = int.Parse(Console.ReadLine());

int factorial = CalculateFactorial(number);
int sumOfDigits = CalculateSumOfDigits(factorial);

Console.WriteLine($"The factorial of {number} is {factorial}");
Console.WriteLine($"The sum of digits of factorial is {sumOfDigits}");

static int CalculateFactorial(int number)
{
    if (number == 0)
        return 1;

    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }    
    return result;
}

static int CalculateSumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }

    return sum;
}