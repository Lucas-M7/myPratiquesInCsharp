using Structs.MyStrus;

//Horario agora; // Instanciando a Struct e declarando uma variável

//Inserindo os dados nas variavéis da Struct.
// agora.hora = 12;
// agora.minuto = 30;

// Console.WriteLine("Horário: {0}:{1}", agora.hora, agora.minuto);

Horario agora = new(13, 13, 00); // Definindo os valores dos parâmetros da Struct
Console.WriteLine("Agora são {0} horas", agora.Hora());

var point = new Coordenadas(-3, 5); // Instanciando a Struct e já colocando em uma variável
Console.WriteLine($"Coordenadas atual: {point}");

var temp = new Temperature(27);
Console.WriteLine($"A temperatura atual é: {temp}");