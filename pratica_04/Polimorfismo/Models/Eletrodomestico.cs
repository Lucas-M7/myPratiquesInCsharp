using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;

        public Eletrodomestico(string nome) // Constructor want the name of eletrodomestic
        {
            _nome = nome;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public void Testar()
        {
            
        }
    }
}