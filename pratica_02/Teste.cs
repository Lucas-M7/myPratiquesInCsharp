using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pratica_02;

namespace pratica_02
{
    public class Teste
    {
        public void Comparar<T>(T p1, T p2)
        {
            Console.WriteLine($"Os tipos: {p1.GetType()} e {p2.GetType()}\n");
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}\n");
        }
    }
}