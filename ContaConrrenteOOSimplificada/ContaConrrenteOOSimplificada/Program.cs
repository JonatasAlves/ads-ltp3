using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaConrrenteOOSimplificada
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ct1 = new ContaCorrente(1231234);
            ct1.Depositar(1000);

            ContaCorrente ct2 = new ContaCorrente(8652135);
            ct2.Depositar(500);

            ct2.Sacar(200);

            Console.WriteLine("Transferir >>>>>>>>");
            ct1.Transferir(ct2, 1000);

            Console.WriteLine("Conta {0} = {1}",
                ct1.conta, ct1.GetSaldo());
            Console.WriteLine("Conta {0} = {1}",
                ct2.conta, ct2.GetSaldo());

            Console.ReadKey();
        }
    }
}
