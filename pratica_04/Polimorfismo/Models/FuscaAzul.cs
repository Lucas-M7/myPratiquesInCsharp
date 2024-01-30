using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class FuscaAzul : Carro
    {

        private int _velocidade;
        public FuscaAzul(string nome) : base(nome)
        {
        }

        public int Velocidade
        {
            get = _velocidade;

            set
            {
                _velocidade += 20;
            }
        }
    }

        public override void Acelerar()
        {
            Console.WriteLine("O fusca tá a 20KM/H");
        }

        public override void DesligarCarro()
        {
            Console.WriteLine("O fusca tá desligado");
        }

        public override void Frear()
        {
            Console.WriteLine("O fusca tá a 10KM/H");
        }

        public override void LigarCarro()
        {
            Console.WriteLine("O fusca tá ligado");
        }
    }
}