using FluentAssertions.Formatting;
using MongoDB.Driver;
using Project.Model;

var client = new MongoClient("mongodb+srv://lucas015x:Duka!0908@usersproject.ustlui4.mongodb.net/");

var bancoDeDados = client.GetDatabase("Users");
var colecao = bancoDeDados.GetCollection<Usuario>("MyUsers");

while (true)
{
    Console.WriteLine("Escolha uma opção!\n");
    Console.WriteLine("1. Cadastrar usuário!");
    Console.WriteLine("2. Listar usuários!");
    Console.WriteLine("3. Sair");
    Console.Write("Opção: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite o nome do usuário:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do usuário:");
            var idade = Console.ReadLine();
             Console.WriteLine("Digite o email do usuário:");
            var email = Console.ReadLine();
            Console.WriteLine("Digite o estado do usuário:");
            var estado = Console.ReadLine();

#pragma warning disable CS8601 // Possível atribuição de referência nula.
            var usuario = new Usuario
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Estado = estado
            };
#pragma warning restore CS8601 // Possível atribuição de referência nula.

            colecao.InsertOne(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
            break;

        case "2":
            var usuarios = await colecao.Find(x => true).ToListAsync();
            Console.WriteLine("Lista de usuários:");
            foreach (var user in usuarios)
            {
                Console.WriteLine($"Nome: {user.Nome}, Idade: {user.Idade}, Email: {user.Email}, Estado: {user.Estado}");
            }
            break;

        case "3":
            Console.WriteLine("Saindo...");
            return;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
}