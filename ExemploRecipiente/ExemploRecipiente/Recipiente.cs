using System;

namespace ExemploRecipiente
{
    public class Recipiente
    {
        private int capacidade;
        private int quantidade;

        public Recipiente(int cp)
        {
            int capacidade1 = 0;


            capacidade = cp + capacidade1;
        }

        public void AlteraQuantidade(int novaQuantidade)
        {
            if (novaQuantidade < 0 ||
                novaQuantidade > capacidade)
            {
                return;
            }

            capacidade = novaQuantidade;

            //if (novaQuantidade >= 0 && 
            //    novaQuantidade <= capacidade)
            //{
            //    quantidade = novaQuantidade;
            //}
        }

        public int RecuperaCapacidade()
        {
            return capacidade;
        }
    }
}
