using System.Collections;
using Polimorfismo.Models;

// var cafe1 = new Cafeteira(nome: "Cafeteira of Luquinhas");
// cafe1.PreparaCafe();
// cafe1.Ligar();
// cafe1.Desligar();

// var carro = new FuscaAzul("Fusquinha");

// carro.Velocidade = 39;
// carro.Acelerar();
// carro.Frear();




static void FazerAlgo()
{
    string seiLa = "Dukinha";
    if (seiLa == "Dukinha")
    {
        Console.WriteLine($"{seiLa} Pressão");
    }
    else
    {
        Console.WriteLine("Sei lá");
    }
}

try
{
    FazerAlgo();
}
catch
{
    throw new ArgumentException("Deu Ruim");
}
finally
{
    Console.WriteLine("Finalmente terminou essa bomba");
}