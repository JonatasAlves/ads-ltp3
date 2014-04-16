using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponto2DOO
{
    public class Ponto2D
    {
        // Atributos X, Y
        private double x;
        private double y;

        public Ponto2D()
        {
            x = 0;
            y = 0;
        }

        public Ponto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Ponto2D(Ponto2D ponto)
        {
            x = ponto.x;
            y = ponto.y;
        }

        public double GetX()
        {
            return x;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Movimentar()
        {
            x = 0;
            y = 0;
        }

        public void Movimentar(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Movimentar(Ponto2D ponto)
        {
            this.x = ponto.x;
            this.y = ponto.y;
        }

        public bool Equals(Ponto2D ponto)
        {
            return ponto.x == x && ponto.y == y;
            /*
            if(ponto.x == x && ponto.y == y)
                return true;
            else
                return false;
            */
        }

        public String ToString()
        {
            return "(" + x + ", " + y + ")";
            // printf("(%f, %f)", x, y);
        }

        public double Distancia(Ponto2D ponto)
        {
            return
                Math.Sqrt(
                    Math.Pow(ponto.x - x, 2) +
                    Math.Pow(ponto.y - y, 2));
        }

        public Ponto2D Clone()
        {
            return new Ponto2D(this);
        }
    }
}
