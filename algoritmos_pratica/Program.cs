static int PesquisaBinaria(int[] lista, int item)
{
    int baixo = 0;
    // Baixo e alto acompanham a parte da lista que está sendo procurada
    int alto = lista.Length - 1;

    while (baixo <= alto) // Enquanto não consegue chegar ao elemento
    {
        int meio = (baixo + alto) / 2; // Verifica o elemento central
        int chute = lista[meio];

        if (chute == item) // Achar o item
        {
            return meio;
        }
        else if(chute > item) // Chute foi muito alto
        {
            alto = meio - 1;
        }
        else // Chute foi muito baixo
        {
            baixo = meio + 1;
        }
    }

    return 0; // O item não existe
}

int[] minhaLista = [1, 3, 6, 8, 10]; // Hora de testar

Console.WriteLine(PesquisaBinaria(minhaLista, 8)); // Retorna o índice do elemento escolhido