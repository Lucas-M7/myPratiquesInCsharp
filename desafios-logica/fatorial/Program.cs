static void MostrarFatorialDeUmNumero(int numero)
{
    int fatorial = 1;
    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }
    Console.WriteLine($"O fatorial de {numero} é {fatorial}");
}

MostrarFatorialDeUmNumero(5);