using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class convertidor_temperatura //2. Hacer un algoritmo que convierta una temperatura de grados Celsius a Fahrenheit.
        {
            public static void Ejecutar()
            {
                float celsius, fahrenheit;

                Console.Write("Ingrese la temperatura en celsius: ");
                celsius = float.Parse(Console.ReadLine()!);
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.Write($"La temperatura en fahrenheit es {fahrenheit}");

            }
        }
}
