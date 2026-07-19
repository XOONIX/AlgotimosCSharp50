using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
        class promedio_5_calificaciones // 3. Hacer un algoritmo que calcule el promedio de cinco calificaciones.
        {
            public static void Ejecutar()
            {
                float not1, not2, not3, not4, not5, promedio;

                Console.Write("Ingrese una nota: ");
                not1 = float.Parse(Console.ReadLine()!);
                Console.Write("Ingrese una nota: ");
                not2 = float.Parse(Console.ReadLine()!);
                Console.Write("Ingrese una nota: ");
            not3 = float.Parse(Console.ReadLine()!);


                Console.Write("Ingrese una nota: ");
            not4 = float.Parse(Console.ReadLine()!);


                Console.Write("Ingrese una nota: ");
            not5 = float.Parse(Console.ReadLine()!);



            promedio = (not1 + not2 + not3 + not4 + not5) / 5;



            Console.Write($"El promedio de las notas es {promedio}");
            }
        }
 }

