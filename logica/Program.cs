using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {
        string arquivoZIP = "teste.zip"; // Nome do arquivo ZIP na raiz do projeto
        string senhaCorreta = null;
        bool senhaEncontrada = false;
        
        // Define o range de senhas a serem testadas
        int inicioRange = 0;
        int fimRange = 9999;

        // Realiza tentativas em paralelo usando múltiplas threads
        Parallel.For(inicioRange, fimRange + 1, (tentativa, estado) => {
            if (!senhaEncontrada) {
                string senha = tentativa.ToString("D4"); // Formata os números com quatro dígitos (0 à esquerda)

                try {
                    using (FileStream fileStream = File.OpenRead(arquivoZIP)) {
                        using (ZipArchive archive = new ZipArchive(fileStream, ZipArchiveMode.Read)) {
                            foreach (ZipArchiveEntry entry in archive.Entries) {
                                if (entry.FullName != string.Empty) {
                                    // Tenta extrair cada arquivo com a senha atual
                                    ExtractEntryWithPassword(entry, Path.Combine(Path.GetTempPath(), entry.FullName), senha);
                                }
                            }
                        }
                    }

                    // Se não houve exceção, a senha está correta
                    senhaCorreta = senha;
                    senhaEncontrada = true;
                    estado.Break(); // Para a execução das outras threads
                } catch (InvalidDataException) {
                    // A exceção é lançada quando a senha está incorreta, então continuamos para a próxima tentativa
                }
            }
        });

        if (senhaEncontrada) {
            Console.WriteLine($"Senha correta encontrada: {senhaCorreta}");
        } else {
            Console.WriteLine("Senha não encontrada.");
        }
    }

    static void ExtractEntryWithPassword(ZipArchiveEntry entry, string destinationPath, string password) {
        using (Stream entryStream = entry.Open())
        using (FileStream destinationStream = File.Create(destinationPath)) {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = entryStream.Read(buffer, 0, buffer.Length)) > 0) {
                destinationStream.Write(buffer, 0, bytesRead);
            }
        }
    }
}
