namespace array.Colecoes.Helper;
public class OperacoesArray
{
    public void OrdenarBubbleSort(int[] arr)
    {
        int temp = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    
    public void ImprimirArray(int[] arr)
    {
        var linha = string.Join(", ", arr);
            Console.WriteLine(linha);
    }
}
