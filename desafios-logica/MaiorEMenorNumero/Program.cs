static void EncontrarMaiorEMenor(int[] lista) {
    if(lista == null) {
        Console.WriteLine("Lista Vazia");
    } else {
        int menor = lista[0], maior = lista[0];

        foreach (var numero in lista) {
            if (numero < menor) {
                menor = numero;
            } else if (numero > maior) {
                maior = numero;
            } else {
                Console.WriteLine($"{menor}, {maior}");
            }
        }
    }
}

int[] listaNumero = [74, -74, 748, 0, 1, 473, 74];
EncontrarMaiorEMenor(listaNumero);