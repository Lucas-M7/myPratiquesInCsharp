using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira(string nome) : base(nome)
        {

        }

        private static void AquecerAgua()
        {

        }

        private static void ColocarCapsula()
        {

        }

        public void PreparaCafe()
        {
            AquecerAgua();
            ColocarCapsula();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }

        public override void Desligar()
        {
            throw new NotImplementedException();
        }
    }
}