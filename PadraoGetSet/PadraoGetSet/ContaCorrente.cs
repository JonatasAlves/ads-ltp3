using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoGetSet
{
    public class ContaCorrente
    {
        private double saldo;

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            if (saldo > 0)
            {
                this.saldo = saldo;
            }
        }
    }
}
