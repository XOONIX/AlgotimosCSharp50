using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class MayorDosNumeros
    {
        public static void Ejecutar()
        {
            int num1, num2;
            Console.WriteLine("Ingresa un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"El numero mayor es {num1}");
            }
            else
            {
                Console.WriteLine($"El numero mayor es {num2}");
            }
        }
    }
}


