using Encapsulamento.Models;

var user1 = new Login();

user1.NomeDoUsuario = "Lucas";
user1.Email = "exemplo@email.com";
user1.Idade = 18;

Console.WriteLine($"Name: {user1.NomeDoUsuario}");
Console.WriteLine($"Email: {user1.Email}");
Console.WriteLine($"Idade: {user1.Idade}");