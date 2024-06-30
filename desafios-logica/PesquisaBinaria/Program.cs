static int PesquisaBinaria(int[] lista, int item)
{
    int baixo = 0;
    int alto = lista.Length - 1;

    while (baixo <= alto)
    {
        int meio = baixo + (alto - baixo) / 2;

        if (lista[meio] == item)
            return meio;

        if (lista[meio] < item)
            baixo = meio + 1;

        else
            alto = meio - 1;        
    }

    return -1;
}

int[] minhaLista = [1, 2, 3, 6, 8, 9];
Console.WriteLine(PesquisaBinaria(minhaLista, 8));