using Exercise01.Users;

List<Usuarios> usuarios =
        [
            new Usuarios { Nome = "Lucas", Idade = 18, Estado = "Pernambuco" },
            new Usuarios { Nome = "Amanda", Idade = 17, Estado = "Rio de Janeiro" },
            new Usuarios { Nome = "Fábio", Idade = 19, Estado = "Paraiba" },
            new Usuarios { Nome = "Ana", Idade = 21, Estado = "Bahia" },
            new Usuarios { Nome = "Clara", Idade = 16, Estado = "Pernambuco" }
        ];

var maioresDeIdade = from usuario in usuarios
                     where usuario.Idade >= 18
                     select usuario;

Console.WriteLine("\nUsuários Maiores de Idade----------\n");

foreach (var pessoa in maioresDeIdade)
{
    Console.WriteLine($"Usuário Maior de Idade - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Estado: {pessoa.Estado}");
}

var residentesPernambuco = from pessoa in usuarios
                           where pessoa.Estado == "Pernambuco"
                           select pessoa;

Console.WriteLine("\nUsuários de PE----------\n");

foreach (var item in residentesPernambuco)
{
    Console.WriteLine($"Usuário de Pernambuco - Nome: {item.Nome}, Idade: {item.Idade}, Estado: {item.Estado}");
}