using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal1;
            cal1 = new Calculadora();

            cal1.Somar(100);
            cal1.Subtrair(200); // Resultado = -100

            cal1.MostrarResultado();

            cal1.Dividir(4); // Resultado: -25

            cal1.MostrarResultado();

            Calculadora cal2;
            cal2 = new Calculadora();

            cal2.Somar(1000);
            cal2.Dividir(4);
            cal2.MostrarResultado(); // Resultado: 250
        }
    }
}
