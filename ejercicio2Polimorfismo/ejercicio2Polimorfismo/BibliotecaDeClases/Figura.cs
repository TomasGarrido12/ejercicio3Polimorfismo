using System;

namespace BibliotecaDeClases
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando un...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}
