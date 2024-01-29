using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Geladeira : Eletrodomestico
    {
        public Geladeira(string nome) : base(nome)
        {
            nome = "Geladeira";
        }

        public override void Desligar()
        {
            Console.WriteLine("Geladeira Desligada");
        }

        public override void Ligar()
        {
            Console.WriteLine("Geladeira Ligada");
        }
    }
}