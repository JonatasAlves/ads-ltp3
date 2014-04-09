using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContador2
{
    class Contador
    {
        private int valor;

        public void Zerar()
        {
            valor = 0;
        }

        public void Incrementar()
        {
            valor++;
        }

        public int RetornarValor()
        {
            return valor;
        }
    }
}
