using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1000;
            byte numeroMeses = 5;
            double decimoTerceiro = (salario / 12) * numeroMeses;
            Console.WriteLine("O valor do décimo terceiro será: {0:C}", decimoTerceiro);
        }
    }
}
