using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContador2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador ct1 =  new Contador();
            ct1.Incrementar();
            ct1.Incrementar();

            Console.WriteLine(ct1.RetornarValor());

            for (ct1.Zerar(); ct1.RetornarValor() < 100; ct1.Incrementar())
            {
                Console.WriteLine("O valor do contador eh {0}",
                    ct1.RetornarValor());
            }

            Console.ReadKey();
        }
    }
}
