using poo.Veiculos.Carros;

namespace poo.Veiculos.CarSport;

public class CarroEsportivo : Carro
{
    // Propriedades específicas para um carro esportivo.
    public bool Turbo { get; set; }

    public CarroEsportivo(string modelo, string marca, int ano, bool turbo) : base(modelo, marca, ano)
    {
        Turbo = turbo;
    }

    // Método específico para um carro esporitivo.
    public void AtivarTurbo()
    {
        Console.WriteLine("Turbo ativado!");
    }
}