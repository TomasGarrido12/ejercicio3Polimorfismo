using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Rectangulo:Figura
    {
        protected int _base; // reveer esto tipo de acceso, deberia ser privado pero cuando voy al tipo Cuadrado me genera errores en el constructor de Cuadrado por el tipo de acceso del atributo

        public int _Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public int altura;

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public Rectangulo(int _base, int altura)
        {
            this._base = _base;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando un rectangulo...";
        }

        public override double CalcularPerimetro()
        {
            return (double)(2*_base) + (2*altura);
        }
        public override double CalcularSuperficie()
        {
            return (double)_base * altura;
        }
    }
}
