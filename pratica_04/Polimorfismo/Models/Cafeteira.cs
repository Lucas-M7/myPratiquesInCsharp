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
            Console.WriteLine("Água está sendo aquecida");
        }

        private static void ColocarCapsula()
        {
            Console.WriteLine("\nCapsula está sendo colocada");
        }

        public void PreparaCafe()
        {
            AquecerAgua();
            ColocarCapsula();

            Console.WriteLine("\nCafé estará pronto após os próximos passos");
        }

        public override void Ligar()
        {
            Console.WriteLine("\nCafeteira Ligada");
        }

        public override void Desligar()
        {
            Console.WriteLine("\nCafeteira Desligada");

            Console.WriteLine("\nSeu café está pronto");
        }
    }
}