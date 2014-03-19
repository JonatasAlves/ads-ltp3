using System;

namespace CalculaOO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculadora cal1;
            cal1 = new Calculadora();
            cal1.Somar(10);

            cal1.MostrarSaldo();
            cal1.Subtrair(100);

            cal1.MostrarSaldo();

            Calculadora cal2;
            cal2 = new Calculadora();
            cal2.Somar(1000);
            cal2.Dividir(4);

            cal2.MostrarSaldo();
        }
    }
}