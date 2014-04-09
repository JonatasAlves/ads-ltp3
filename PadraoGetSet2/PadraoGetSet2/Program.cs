using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoGetSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente("123");
            cli1.SetNome("Joao da Silva");
            cli1.SetIdade(-1);

            Console.WriteLine("O cliente {0} {2} tem {1} anos de idade",
                cli1.GetNome(), cli1.GetIdade(),
                cli1.GetCpf());
        }
    }
}
