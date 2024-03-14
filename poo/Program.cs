using poo.Encapsulamento;
// using poo.Veiculos.CarSport;

// CarroEsportivo porsche = new(modelo:"Taycan", marca:"Porsche", ano:2024, turbo:true);


// porsche.Ligado(porsche.Modelo);
// porsche.Mover(porsche.Modelo);
// porsche.AtivarTurbo();
// Console.WriteLine($"\nO {porsche.Marca} no modelo {porsche.Modelo} do ano {porsche.Ano} está a 320KM/h!");

ContaBancaria conta = new();

conta.Saldo = 150000;

conta.MostrarSaldo();
conta.Sacar(7474);
conta.MostrarSaldo();