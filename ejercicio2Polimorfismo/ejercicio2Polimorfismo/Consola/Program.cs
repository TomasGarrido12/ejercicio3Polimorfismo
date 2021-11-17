using System;
using System.Text;
using BibliotecaDeClases;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(20,30);
            Cuadrado cuadrado = new Cuadrado(15,50);
            Circulo circulo = new Circulo(10);
            List<Figura> figuras = new List<Figura>();

            figuras.Add(rectangulo);
            figuras.Add(cuadrado);
            figuras.Add(circulo);

            foreach (Figura figura in figuras)
            {
                Console.WriteLine($"--------FIGURA----------");
                Console.WriteLine($"Tipo:{figura.GetType().Name}");
                Console.WriteLine(figura.Dibujar());
                if (figura == rectangulo || figura == cuadrado)
                {
                    Console.WriteLine($"Base:{rectangulo._Base}");
                    Console.WriteLine($"Altura:{rectangulo.altura}");
                }
                else if (figura == circulo)
                {
                    Console.WriteLine($"Radio:{circulo.Radio}");
                }
                Console.WriteLine($"Perimetro:{figura.CalcularPerimetro()}");
                Console.WriteLine($"Area:{figura.CalcularSuperficie()}");
            }
            
            
        }
    }
}
