using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto2DOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto2D p1 = new Ponto2D();
            Ponto2D p2 = new Ponto2D(5, 5);
            Ponto2D p3 = new Ponto2D(p2);
            Ponto2D p4 = p3.Clone();

            double distancia = p1.Distancia(p4);

            Console.WriteLine("Ponto 1: {0}", p1.ToString());
            Console.WriteLine("Ponto 2: {0}", p2.ToString());
            Console.WriteLine("Ponto 3: {0}", p3.ToString());
            Console.WriteLine("Ponto 4: {0}", p4.ToString());

            Console.WriteLine(
                "Distância: {0}", distancia);

            Console.ReadKey();
        }
    }
}
