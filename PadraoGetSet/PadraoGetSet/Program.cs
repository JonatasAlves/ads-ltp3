using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado em1 = new Empregado(
                "João", "Silva", 1000);
            Empregado em2 = new Empregado(
                "Pedro", "Souza", 1200);

            Console.WriteLine("Salario Anual de {0} {1} é {2}",
                em1.GetPrimeiroNome(), em1.GetUltimoNome(), 
                em1.GetSalario() * 12);

            Console.WriteLine("O {1}, {0} receberá {2:C}",
                em2.GetPrimeiroNome(), em2.GetUltimoNome(), 
                em2.GetSalario() * 12);

            em1.SetSalario(em1.GetSalario() * 1.1);
            em2.SetSalario(em2.GetSalario() * 1.1);

            Console.WriteLine("Aplicado Aumento >>>>>>");

            Console.WriteLine("Salario Anual de {0} {1} é {2}",
                em1.GetPrimeiroNome(), em1.GetUltimoNome(), 
                em1.GetSalario() * 12);

            Console.WriteLine("Salario Anual de {0} {1} é {2}",
                em2.GetPrimeiroNome(), em2.GetUltimoNome(), 
                em2.GetSalario() * 12);

        }
    }
}
