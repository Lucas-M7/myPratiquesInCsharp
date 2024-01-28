using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica_01.Models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataDaVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataDaVenda { get; set; }
    }

    public class Cliente
    {
        private string _nome;
        private int _idade;

        public string NomeDoCliente
        {
            get => _nome;
            set
            {
                if (value == "" || value == " ")
                {
                    throw new ArgumentException("O campo do nome não pode ficar vazio");
                }
                _nome = value;
            }
        }
        public int IdadeDoCliente
        {
            get => _idade;
        
            set
            {
                if (value == 0 || value < 0 || value < 18)
                {
                    throw new ArgumentException("Idade inválida para realizar a compra do produto");
                }
                _idade = value;
            }
        }
    }
}