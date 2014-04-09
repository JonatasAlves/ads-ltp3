using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetAsProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "João";

            Aluno aluno2 = new Aluno();
            aluno2.Nome = "Pedro";
        }
    }
}
