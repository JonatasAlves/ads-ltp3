using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContador
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador ct = new Contador();
            ct.Incrementar();
            ct.Incrementar();

            Console.WriteLine(ct.RetornarValor());

            ct.Zerar();
            ct.Incrementar();
            Console.WriteLine(ct.RetornarValor());
            Console.ReadKey();
        }
    }
}
