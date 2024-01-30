using Encapsulamento.Models;

var user1 = new Login();

user1.Nickame = "CyberSync777";
user1.Email = "exemplo@email.com";
user1.Idade = 18;

Console.WriteLine($"Name: {user1.Nickame}");
Console.WriteLine($"Email: {user1.Email}");
Console.WriteLine($"Idade: {user1.Idade}");