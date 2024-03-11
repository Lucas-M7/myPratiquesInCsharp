using poo.Veiculos.CarSport;

CarroEsportivo porsche = new(modelo:"Taycan", marca:"Porsche", ano:2024, turbo:true);


porsche.Ligado(porsche.Modelo);
porsche.Mover(porsche.Modelo);
porsche.AtivarTurbo();
Console.WriteLine($"\nO {porsche.Marca} no modelo {porsche.Modelo} do ano {porsche.Ano} está a 320KM/h!");