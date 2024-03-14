namespace poo.Encapsulamento;
public class ContaBancaria
{
    private double _saldo;

    public double Saldo
    {
        get => _saldo; 
        
        set
        {
            _saldo = value;
        }
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= _saldo)
        {
            _saldo -= valor;

            Console.WriteLine($"Saque realizado no valor de {valor}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Seu saldo atual é de {_saldo}");
    }
}
