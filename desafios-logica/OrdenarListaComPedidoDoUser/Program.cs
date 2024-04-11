Console.WriteLine("Digit the numbers separeds for space");

string input = Console.ReadLine();

string[] numbersString = input.Split(' ');
int[] numbers = new int[numbersString.Length];

for (int i = 0; i < numbersString.Length; i++)
{
    if (!int.TryParse(numbersString[i], out numbers[i]))
    {
        Console.WriteLine("Please, insert only valid numbers.");
        return;
    }
}

Console.WriteLine("Want classificate in order hight or low? (hight/low)");
string option = Console.ReadLine().ToLower();

if (option == "hight")
{
    Array.Sort(numbers);
}
else if (option == "low")
{
    Array.Sort(numbers);
    Array.Reverse(numbers);
}
else
{
    Console.WriteLine("Invalid option. Please, writte 'hight' or 'low'.");
}

Console.WriteLine("Numbers in order:");
foreach(int number in numbers)
{
    Console.WriteLine(number + " ");
}