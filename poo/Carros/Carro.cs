namespace poo.Veiculos.Carros;

public class Carro : Veiculo
{
    public string Modelo { get; set; } = default!;
    public string Marca { get; set; } = default!;
    public int Ano { get; set; }

    public Carro(string modelo, string marca, int ano)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }

    public void Ligado(string modelo)
    {
        Console.WriteLine($"O {modelo} está ligado.");
    }

    public void Desligado(string modelo)
    {
        Console.WriteLine($"O {modelo} está desligado");
    }

    public override void Mover(string veiculo)
    {
        Console.WriteLine($"O {veiculo} está acelerando.");
    }
}