using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoResidencial
{
    class Program
    {
        struct TV
        {
            public String Identificador;
            public String Modelo;
            public String Marca;
            public String Localizacao;
            public int Tamanho;
        }

        static void Main(string[] args)
        {
            TV tv1 = new TV();
            tv1.Identificador = "TV1"; 
            LigarTV(tv1);
            DesligarTV(tv1);

            Console.ReadKey();

        }

        static void LigarTV(TV tv)
        {
            Console.WriteLine("A TV {0} foi ligada", 
                tv.Identificador);
        }

        static void DesligarTV(TV tv)
        {
            Console.WriteLine("A TV {0} foi desligada",
                tv.Identificador);
        }
    }
}
