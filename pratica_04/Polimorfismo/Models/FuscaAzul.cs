using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            get => _velocidade;

            set
            {
                _velocidade = 20;
                _velocidade += value;
            }
        }

        public override void Acelerar()
        {
            Console.WriteLine($"O carro tá a {Velocidade} Km/h");
        }

        public override void DesligarCarro()
        {
            Console.WriteLine("O fusca tá desligado");
        }

        public override void Frear()
        {
            Console.WriteLine($"O fusca tá a {Velocidade -= 10} Km/h");
        }

        public override void LigarCarro()
        {
            Console.WriteLine("O fusca tá ligado");
        }
    }
}