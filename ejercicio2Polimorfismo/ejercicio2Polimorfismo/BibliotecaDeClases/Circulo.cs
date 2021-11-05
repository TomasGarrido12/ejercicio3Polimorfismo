using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Circulo:Figura
    {
        private int radio;

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public Circulo(int radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return base.Dibujar() + "circulo";
        }

        public override double CalcularSuperficie()
        {
            return (double) 2*radio;
        }
        public override double CalcularPerimetro()
        {
            return (double) 2*Math.PI*radio;
        }

    }
}
