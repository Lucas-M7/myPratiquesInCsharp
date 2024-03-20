// Imprimir números de 1 a 100
// Caso for múltiplo de 3 = Fizz, de 5 = Buzz, 3 e 5 = FizzBuzz
// Caso não for múltiplo de nenhum dos dois, imprimir o número

for (int i = 1; i <= 100; i++){
  if (i % 3 == 0){
        Console.WriteLine("Fizz");
    }
    else if(i % 5 == 0){
        Console.WriteLine("Buzz");
    }
    else if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    else{
        Console.WriteLine(i);
    }
}