using pratica_01.Models;
using Newtonsoft.Json;


 List<Vendas> listaDasVendas = new List<Vendas>();

 Vendas primeiraVenda = new Vendas(id: 1, produto: "Spy-Ware", preco: 48.00M, dataVenda: DateTime.Now);
 Vendas segundaVenda = new Vendas(id: 2, produto: "Mallware", preco: 100.00M, dataVenda: DateTime.Now);
 Vendas terceiraVenda = new Vendas(id: 3, produto: "Key", preco: 150.00M, dataVenda: DateTime.Now);
 Vendas quartaVenda = new Vendas(id: 4, produto: "Notebook", preco: 3.100M, dataVenda: DateTime.Now);


 listaDasVendas.Add(primeiraVenda);
 listaDasVendas.Add(segundaVenda);
 listaDasVendas.Add(terceiraVenda);
 listaDasVendas.Add(quartaVenda);

 string serializando = JsonConvert.SerializeObject(listaDasVendas, Formatting.Indented);

 File.WriteAllText("Arquivos/itensVendidos.json", serializando);

 Cliente primeiroCliente = new Cliente();

 Console.WriteLine("Digite o seu nome");
 primeiroCliente.NomeDoCliente = Console.ReadLine();

 Console.WriteLine("Digite a sua idade");
 primeiroCliente.IdadeDoCliente = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine($"O cliente {primeiroCliente.NomeDoCliente} obteve o produto {primeiraVenda.Produto} " +
 $"no valor de {primeiraVenda.Preco:c}.");