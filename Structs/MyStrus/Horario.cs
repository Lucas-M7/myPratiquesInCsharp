
namespace Structs.MyStrus;

public readonly struct Horario
{
    private readonly int hora, minuto, segundo;

    public Horario(int h, int m, int s)
    {
        hora = h % 24;
        minuto = m % 60;
        segundo = s % 60;
    }

    public readonly int Hora()
    {
        return hora;
    }
}