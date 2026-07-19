using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    // Ejercicios propuestos por el profe, para explicar el ciclo While 

    class EjercicioPracticaWhile
    {
        public static void Ejecutar()
        {
            //Inserta una N cantidad de numeros 
            int num, i, final;
            Console.Write("Escribe cuantos numeros quieres agregar: ");
            final = int.Parse(Console.ReadLine());

            i = 1;

            while (i <= final)
            {
                Console.Write("Escribe un numero: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Vamos en el numero {i}");
                i += 1;
            }
        }
    }
}
