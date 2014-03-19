using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaOO
{
    class Calculadora
    {
        public double saldo;

        public void Somar(double valor)
        {
            saldo = saldo + valor;
        }

        public void Subtrair(double valor)
        {
            saldo = saldo - valor;
        }

        public void Dividir(double valor)
        {
            saldo = saldo/valor;
        }

        public void Multiplicar(double valor)
        {
            saldo = saldo*valor;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine("Saldo: {0}", saldo);
        }
    }
}
