using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma10Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            String recebe;
            int soma = 0;
            for (int cont = 0; cont < 10; cont++)
            {
                recebe = Console.ReadLine();
                soma = soma + Convert.ToInt32(recebe);
            }

            Console.WriteLine("A soma dos 10 numeros eh {0}", soma);
            Console.ReadKey();
        }
    }
}
