using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga");
        }

        public abstract class Payment
        {
            public DateTime ExpiredDate;
            private void Pay()
            {

            }
        }

        public class Billing : Payment
        {
            void SetBilling()
            {

            }
        }
    }
}

// Treinando os modificadores de acesso