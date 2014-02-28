using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String idade = Console.ReadLine();
            int idadeConvertida = Convert.ToInt32(idade);

            Console.WriteLine("Você viveu aproximadamente {0} dias",
                idadeConvertida * 365);
            Console.ReadKey();
        }
    }
}
