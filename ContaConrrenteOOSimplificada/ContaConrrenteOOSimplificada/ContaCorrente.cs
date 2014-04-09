using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaConrrenteOOSimplificada
{
    class ContaCorrente
    {
        private String clienteCpf;
        public int conta;
        private double limite;
        private double saldo;

        public ContaCorrente(int pConta)
        {
            conta = pConta;
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Deposito {0} -> {1}",
                conta, valor);

            saldo = saldo + valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo = saldo - valor;

                Console.WriteLine("Sacar {0} -> {1}",
                    conta, valor);

                return true;
            }

            return false;
        }

        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);

                return true;
            }

            return false;
        }

        public double GetSaldo()
        {
            return saldo;
        }

    }
}
