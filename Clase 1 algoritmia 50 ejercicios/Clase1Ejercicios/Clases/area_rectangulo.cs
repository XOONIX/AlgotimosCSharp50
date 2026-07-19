using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
        class area_rectangulo //1. Hacer un algoritmo que calcule el área de un rectángulo a partir de su base y altura.
        {
            public static void Ejecutar()
            {
                float baseRectangulo, alturaRectangulo, areaRectangulo;
                Console.Write("Ingrese la base del rectangulo: ");
                baseRectangulo = float.Parse(Console.ReadLine()!);


                Console.Write("Ingrese la altura del rectangulo: ");
                alturaRectangulo = float.Parse(Console.ReadLine()!);

                areaRectangulo = baseRectangulo * alturaRectangulo;
                if (baseRectangulo == 0 || alturaRectangulo == 0)
                {
                    Console.WriteLine("La base o la altura no pueden ser cero");
                }
                else if (alturaRectangulo < 0)
                {
                    Console.WriteLine("La altura no puede ser negativa");
                }
                else if (baseRectangulo < 0)
                {
                    Console.WriteLine("La base no puede ser negativa");
                }
                else
                {
                    Console.WriteLine($"El area del rectangulo es {areaRectangulo}");
                }
            }
        }
}
