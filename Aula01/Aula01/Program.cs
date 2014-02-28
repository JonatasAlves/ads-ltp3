using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            String idade = Console.ReadLine();

            int idadeConvertida = Convert.ToInt32(idade);

            Console.WriteLine("O total de dias vividos eh: {0}", 
                idadeConvertida * 365);

            Console.ReadKey();
        } 
    }
}
