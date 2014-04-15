using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOO
{
    public class Invoice
    {
        private int numeroItem;
        private String descricao;
        private int quantidade;
        private double preco;


        public Invoice(int numeroItem, String descricao,
            int quantidade, double preco)
        {
            if (quantidade < 0)
            {
                quantidade = 0;
            }

            if (preco < 0)
            {
                preco = 0;
            }

            this.numeroItem = numeroItem;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public int NumeroItem
        {
            get { return numeroItem; }
            set { numeroItem = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public double GetInvoiceAmount()
        {
            return quantidade * preco;
        }
    }
}
