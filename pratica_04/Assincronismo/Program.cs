using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

class Programm
{
    static async Task Main() // Início do Programa
    {
        Console.WriteLine("Início do programa");

        await BaixarImagensAsync(); // Chamando o método assíncrono

        Console.WriteLine("Fim do programa"); // Executado após o fim do método acima
    }

    static async Task BaixarImagensAsync()
    {
        List<string> urls = new List<string>
        {
            "https://th.bing.com/th/id/OIP.jTTI_l0H30mcxSsK1dz-5gHaEK?rs=1&pid=ImgDetMain",
            "https://hitpcgames.com/wp-content/uploads/2020/02/stardew-valley-download-pc-game-2048x1152.jpg",
            // Adicione mais URLs de imagens conforme necessário
        };

        List<Task<byte[]>> tarefasDownload = new List<Task<byte[]>>();

        // Iniciar as operações assíncronas para baixar imagens
        foreach (var url in urls)
        {
            tarefasDownload.Add(BaixarImagemAsync(url));
        }

        // Esperar até que todas as operações assíncronas de download sejam concluídas
        byte[][] imagens = await Task.WhenAll(tarefasDownload);

        // Processar as imagens (simulando processamento, neste caso, apenas exibindo o comprimento)
        foreach (var imagem in imagens)
        {
            Console.WriteLine($"Tamanho da imagem: {imagem.Length} bytes");
        }
    }

    static async Task<byte[]> BaixarImagemAsync(string url, HttpClient httpClient = null, CancellationToken cancellationToken = default)
    {
        // Usar o HttpClient fornecido ou criar um novo se nenhum for fornecido
        using (var client = httpClient ?? new HttpClient())
        {
            try
            {
                // Simular uma chamada assíncrona para baixar uma imagem
                HttpResponseMessage response = await client.GetAsync(url, cancellationToken);

                // Simular o processamento da resposta
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync();
            }
            catch (HttpRequestException ex)
            {
                // Lidar com exceções ou retornar null (dependendo dos requisitos)
                Console.WriteLine($"Erro ao baixar a imagem: {ex.Message}");
                return null;
            }
        }
    }
}
