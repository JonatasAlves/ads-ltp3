using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoGetSet2
{
    class Cliente
    {
        private String nome;
        private int idade;
        private String cpf;

        public Cliente(string cpf)
        {
            this.cpf = cpf;
        }

        public String GetCpf()
        {
            return cpf;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            if (idade < 0)
            {
                idade = 0;
            }
            this.idade = idade;
        }
    }
}
