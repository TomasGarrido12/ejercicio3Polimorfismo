using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public sealed class Cuadrado:Rectangulo
    {
        public override string Dibujar()
        {
            return base.Dibujar() + "cuadrado"; // como hacer que tome el Metodo Dibujar() pero de la clase figura, ahora me esta tomando de la clase Rectangulo
        }
        public Cuadrado(int _base, int altura) : base(_base, altura)
        { 
        }
        public override double CalcularPerimetro()
        {
            return (double) 4*_base;
        }
        public override double CalcularSuperficie()
        {
            return base.CalcularSuperficie();
        }
    }
}
