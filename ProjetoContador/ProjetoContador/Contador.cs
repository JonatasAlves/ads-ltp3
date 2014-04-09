﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContador
{
    class Contador
    {
        private int valor;

        public void Incrementar()
        {
            valor++;
        }

        public void Zerar()
        {
            valor = 0;
        }

        public int RetornarValor()
        {
            return valor;
        }
    }
}
