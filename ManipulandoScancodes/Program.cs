Dictionary<ConsoleKey, ConsoleKey> keyMap = new Dictionary<ConsoleKey, ConsoleKey>
{
    { ConsoleKey.L, ConsoleKey.U },
    { ConsoleKey.U, ConsoleKey.C },
    { ConsoleKey.C, ConsoleKey.A },
    { ConsoleKey.A, ConsoleKey.S },
    { ConsoleKey.S, ConsoleKey.M }
};

Console.WriteLine("Pressione ESC para sair.");

while (true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
    ConsoleKey originalKey = keyInfo.Key;

    if (keyMap.ContainsKey(originalKey)) {

        ConsoleKey mappedKey = keyMap[originalKey];
        Console.WriteLine(mappedKey);
    }
    else {

        Console.WriteLine($"Tecla pressionada: {originalKey}");
    }

    if (originalKey == ConsoleKey.Escape) {

        break;
    }
}