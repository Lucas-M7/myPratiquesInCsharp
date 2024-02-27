namespace CaixeiroViajante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coordenadas das cidades
            List<(double, double)> cities =
            // Nessa lista, tem 5 cidades com as seguintes coordenadas abaixo
            [
                (0, 0), // 1° Cidade
                (0, 1), // 2° Cidade
                (1, 1), // 3° Cidade
                (2, 2), // 4° Cidade
                (3, 3)  // 5° Cidade
            ];

            // Cálculo de todas as permutações das cidades
            List<List<int>> permutations = []; // Inicializa uma lista de listas que será usada par armazenar todas as permutações possíveis das cidades.
            CalculatePermutations([], Enumerable.Range(0, cities.Count).ToList(), permutations); // Método chamado com uma lista vazia para prefix, uma lista de números de 0 a cities.count - 1

            // Define duas variáveis shortestDistance e shortestPath para acompanhar o caminho mais curto e a menor distância encontrada. 
            // Em seguida, percorre todas as permutações armazenadas na lista permutations e calcula a distância total de cada permutação usando a função CalculateDistance
            double shortestDistance = double.MaxValue;
            List<int> shortestPath = [];

            // Cálculo da distância para cada permutação e manutenção do caminho mais curto
            foreach (var permutation in permutations)
            {
                double distance = 0;

                for (int i = 0; i < permutation.Count - 1; i++)
                {
                    distance += CalculateDistance(cities[permutation[i]], cities[permutation[i + 1]]);
                }

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    shortestPath = permutation;
                }
            }

            Console.WriteLine($"Caminho mais curto: {string.Join(" -> ", shortestPath)}");
            Console.WriteLine($"Distância mínima: {shortestDistance}");
        }

        // Método para calcular todas as permutações
        static void CalculatePermutations(List<int> prefix, List<int> suffix, List<List<int>> permutations)
        {
            if (suffix.Count == 0)
            {
                permutations.Add(new List<int>(prefix));
            }
            else
            {
                for (int i = 0; i < suffix.Count; i++)
                {
                    List<int> newPrefix = new(prefix)
                    {
                        suffix[i]
                    };

                    List<int> newSuffix = new(suffix);
                    newSuffix.RemoveAt(i);

                    CalculatePermutations(newPrefix, newSuffix, permutations);
                }
            }
        }

        // Método para calcular a distância entre duas cidades
        static double CalculateDistance((double, double) city1, (double, double) city2)
        {
            double xDiff = Math.Abs(city1.Item1 - city2.Item1);
            double yDiff = Math.Abs(city1.Item2 - city2.Item2);

            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }
    }
}
