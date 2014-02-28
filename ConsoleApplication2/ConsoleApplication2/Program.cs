using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaPar, somaImpar, recebeConvertido;
            String recebe;

            somaPar = somaImpar = 0;
            for (int i = 0; i < 10; i++)
            {
                recebe = Console.ReadLine();
                recebeConvertido = Convert.ToInt32(recebe);

                if (recebeConvertido%2 == 0)
                    somaPar = somaPar + recebeConvertido;
                else
                    somaImpar = somaImpar + recebeConvertido; // somaImpar += recebeConvertido;
            }

            Console.WriteLine("Soma Pares: {0}\nSoma Ímpares: {1}",
                somaPar, somaImpar);
            Console.ReadKey();


        }
    }
}
