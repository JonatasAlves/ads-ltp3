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
            int x, y;
            for (x = 0; x < 11; x++)
            {
                for (y = 0; y < 11; y++)
                {
                    Console.WriteLine(" {0} x {1} = {2}", 
                        x, y);
                }
            }

            Console.ReadKey();
        }
    }
}
