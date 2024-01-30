using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento.Models
{
    public class Login
    {
        private string _email;
        private string _nome;
        private int _idade;

        public string Nickame
        {
            get => _nome;

            set
            {
                if (value == "" || value.Contains(' '))
                {
                    throw new ArgumentException("Nickname inválido, não coloque espaços, exemplo de nick: DarthVarder");
                }
                _nome = value;
            }
        }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0 || value < 18)
                {
                    throw new ArgumentException("Idade inválida");
                }
                _idade = value;
            }
        }

        public string Email
        {
            get => _email;

            set
            {
                if (value == "" || value.Contains(' '))
                {
                    throw new ArgumentException("O campo de email não pode ficar vazio");
                }
                _email = value;
            }
        }
    }
}