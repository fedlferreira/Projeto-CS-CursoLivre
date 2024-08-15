using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Pessoa
    {
        private string nome;
        private string email;
        private int idade;

    

        //criando metodo get e set:
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
