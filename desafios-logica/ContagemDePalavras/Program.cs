Console.WriteLine("Writte a text");
string? sentence = Console.ReadLine();
CountWords(sentence);

static void CountWords(string sentence)
{
    string[] words = sentence.Split(' ');

    Dictionary<string, int> counting = [];

    foreach (string word in words)
    {
        if (counting.ContainsKey(word))
        {
            counting[word]++;
        }
        else
        {
            counting[word] = 1;
        }
    }

    foreach (KeyValuePair<string, int> pair in counting)
    {
        Console.WriteLine($"'{pair.Key}' appears {pair.Value} time(s)");
    }
}