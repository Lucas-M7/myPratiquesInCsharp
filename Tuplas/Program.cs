// (int, string, string) firstTuple = (18, "Lucas", "Brasil");

// Console.WriteLine($"The candidate {firstTuple.Item2} has {firstTuple.Item1} " +
//                     $"years old and live in {firstTuple.Item3}.\n");


// (double, int) secondTuple = (7.4, 8);

// Console.WriteLine(secondTuple.ToString());
// Console.WriteLine($"Hash code of {secondTuple} is {secondTuple.GetHashCode()}\n");

// var thirdTuple = (0, 1, 2, 3, 4, 5, 6, 7);

// Console.WriteLine($"The item 8 is: {thirdTuple.Item8}");

// Get Min and Max with Tuples

static (int min, int max) FindMinMax(int[] input)
{
    if (input is null || input.Length == 0)
        throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");

    var min = int.MaxValue;
    var max = int.MinValue;

    foreach (var item in input)
    {
        if (item < min)
            min = item;

        if (item > max)
            max = item;
    }

    return (min, max);
}

int[] xs = [4, 9, 7, -3];
var limits = FindMinMax(xs);
Console.WriteLine($"Limits of [{string.Join(" ", xs)}] are {limits.min} and {limits.max}");