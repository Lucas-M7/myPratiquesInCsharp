using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public abstract class Carro
    {
        private readonly string _nomeDoCarro;

        public Carro(string nome)
        {
            _nomeDoCarro = nome;
        }

        public abstract void LigarCarro();
        public abstract void Acelerar();
        public abstract void Frear();
        public abstract void DesligarCarro();
    }
}