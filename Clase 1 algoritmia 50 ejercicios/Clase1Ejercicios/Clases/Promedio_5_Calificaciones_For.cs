using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class Promedio_5_Calificaciones_For
    {
        public static void Ejecutar()
        {
            decimal notas, promedio, suma;
            suma = 0;
            for (int i = 0; i <= 5 - 1; i++)
            {
                Console.WriteLine("Ingresa Una calificacion: ");
                notas = decimal.Parse(Console.ReadLine());
                suma += notas;
            }
            promedio = suma / 5;
            Console.WriteLine($"El promedio es {promedio}");
        }
    }
}
