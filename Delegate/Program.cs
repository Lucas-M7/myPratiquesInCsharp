using Delegate.Models;


Somatoria soma = new(Calculadora.Somar);
soma.Invoke(10, 10);

Potencia quadrado = new(Calculadora.Quadrado);
quadrado.Invoke(29);