using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_06.Models
{
    internal class Encapsulamento
    {
        private string _nome;
        private int _idade;
        private string _email;

        public string Nome 
        { 
            get => _nome;
            
            set
            {
                if (value == "")
                 {
                    new ArgumentException("O campo do nome não pode ficar vazio");
                 }

                _nome = value;
            }
        }
        public int Idade 
        {
            get => _idade;
            
            set
            {
                if (value == 0 || value < 0 || value < 18)
                {
                    new ArgumentException("Idade inválida para realizar o cadastro");
                }

                _idade = value;
            }
        }
        public string Email 
        {
            get => _email;
            
            set
            {
                if (value == "")
                {
                    new ArgumentException("Email inválido");
                }

                _email = value;
    }
        }
    }
}
