namespace Structs.MyStrus;

public readonly struct Temperature(double celsius)
{
    public double Celsius { get; } = celsius;
    public double Fahrenheit => Celsius * 9 / 5 + 32;

    public override string ToString() => $"{Celsius}°C / {Fahrenheit}°F";
}