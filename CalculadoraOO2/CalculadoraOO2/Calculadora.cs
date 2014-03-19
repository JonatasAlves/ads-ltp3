using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO2
{
    class Calculadora
    {
        public double resultado;

        public void Somar(double valor)
        {
            resultado = resultado + valor;
        }

        public void Subtrair(double valor)
        {
            resultado -= valor;
        }

        public void Dividir(double valor)
        {
            resultado /= valor;
        }

        public void Multiplicar(double valor)
        {
            resultado *= valor;
        }

        public void MostrarResultado()
        {
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
