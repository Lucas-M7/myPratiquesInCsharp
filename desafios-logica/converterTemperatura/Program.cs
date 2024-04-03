static void ConverterTemperaturaCParaF(int C)
{
    decimal F = (decimal)((C * 1.8) + 32);

    Console.WriteLine($"A temperatura {C} °C em Fahrenheit é {F} °F");
}

static void ConverterTemperaturaFParaC(int F)
{
    int C = (F - 32) * 5 / 9;

    Console.WriteLine($"A temperatura {F} °F em Celsius é {C} °C");
}

static void ConverterTemperaturaCParaK(int C)
{
    int K = (int)(C + 273.15);

    Console.WriteLine($"A temperatura {C} °C em Kelvin é {K} °K");
}

static void ConverterTemperaturaKParaC(int K)
{
    int C = (int)(K - 273.15);

    Console.WriteLine($"A temperatura {K} °K em Celsius é {C} °C");
}

ConverterTemperaturaCParaF(40);
ConverterTemperaturaFParaC(104);
ConverterTemperaturaCParaK(25);
ConverterTemperaturaKParaC(300);