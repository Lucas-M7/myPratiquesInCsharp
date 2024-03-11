using poo.Veiculos;

namespace poo.Aviao;

public class Aviao : Veiculo
{
    public override void Mover(string modelo)
    {
        Console.WriteLine($"O avião {modelo} está voando.");
    }
}