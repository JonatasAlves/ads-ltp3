using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Data dt1 = new Data();

            dt1.AvancarDias(31);

            Console.WriteLine("Parcela 1: {0}",
                dt1.ToString());

            dt1.AvancarDias(31);

            Console.WriteLine("Parcela 2: {0}",
                dt1.ToString());

            dt1.AvancarDias(31);

            Console.WriteLine("Parcela 3: {0}",
                dt1.ToString());
        }
    }
}
