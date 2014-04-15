using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice nt1 = new Invoice(
                1000, "HD Externo Seagate XP22",
                2, 123.45);

            Console.WriteLine("{0} - {1} - {2} - {3:c}",
                nt1.NumeroItem, nt1.Descricao, nt1.Quantidade,
                nt1.Preco);
            Console.WriteLine("Total: {0:c}", nt1.GetInvoiceAmount());
            
        }
    }
}
