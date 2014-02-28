using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUnoparOO
{
    class Tv
    {
        public int ID;
        int Tamanho;
        int Volume;

        public void Ligar()
        {
            Console.WriteLine("A TV {0} foi ligada", ID);
        }

        public void Desligar()
        {
            Console.WriteLine("A TV {0} foi desligada", ID);
        }
    }
}
