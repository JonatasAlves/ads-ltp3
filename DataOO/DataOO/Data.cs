using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOO
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int dia, int mes, int ano)
        {
            if (dia < 1 || dia > 31)
            {
                dia = 1;
            }
            if (mes < 1 || mes > 12)
            {
                mes = 1;
            }

            if (ano < 1)
            {
                ano = 1;
            }

            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public Data()
        {
            dia = DateTime.Now.Day;
            mes = DateTime.Now.Month;
            ano = DateTime.Now.Year;
        }

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public String ToString()
        {
            return dia + "/" + mes + "/" + ano;
        }

        public void AvancarDia()
        {
            dia++;

            if (dia > 31)
            {
                dia = 1;
                mes++;
            }

            if (mes > 12)
            {
                mes = 1;
                ano++;
            }
        }

        public void AvancarDias(int qtd)
        {
            for(int i = 0; i < qtd; i++)
                AvancarDia();
        }
    }
}
