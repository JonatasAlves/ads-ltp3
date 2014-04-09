using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoGetSet
{
    public class Aluno
    {
        private String nome;
        private int idade;
        private String cpf;

        public Aluno(String nome, String cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public String GetNome()
        {
            return nome;
        }

        public void SetNome(String nome)
        {
            if (nome != null)
            {
                this.nome = nome;
            }
        }

        public String GetCpf()
        {
            return cpf;
        }

    }
}
