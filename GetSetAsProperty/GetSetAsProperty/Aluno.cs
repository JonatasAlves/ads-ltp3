using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetAsProperty
{
    class Aluno
    {
        private static int identity;

        private int id;
        private String nome;
        private String matricula;
        private String celular;

        public Aluno()
        {
            id = ++identity;
        }

        public int Id
        {
            get { return id; }
        }

        public String Nome
        {
            get { return nome; }
            set
            {
                // Nao pode porque
                if (value != "UNOPAR")
                {
                    nome = value;
                }
            }
        }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
    }
}
