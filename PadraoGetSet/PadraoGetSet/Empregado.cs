using System;

namespace PadraoGetSet
{
    class Empregado
    {
        private String primeiroNome;
        private String ultimoNome;
        private double salario;

        public Empregado(String primeiroNome, 
            String ultimoNome, double salario)
        {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
            this.salario = salario;
        }

        public String GetPrimeiroNome()
        {
            return primeiroNome;
        }

        public void SetPrimeiroNome(String primeiroNome)
        {
            this.primeiroNome = primeiroNome;
        }

        public String GetUltimoNome()
        {
            return ultimoNome;
        }

        public void SetUltimoNome(String ultimoNome)
        {
            this.ultimoNome = ultimoNome;
        }

        public double GetSalario()
        {
            return salario;
        }

        public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                salario = 0;
            }
            this.salario = salario;
        }
    }
}
