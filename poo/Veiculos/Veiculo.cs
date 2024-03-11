namespace poo.Veiculos;

public class Veiculo
{
    // Polimorfismo
    public virtual void Mover(string veiculo)
    {
        Console.WriteLine($"O {veiculo} está se movendo.");
    }
}
