using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class MayorTresNumeros
    {
        public static void Ejecutar()
        {
            int num1, num2, num3;
            Console.WriteLine("Ingresa un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ultimo numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El numero {num1} es el mayor");
            }
            else if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine($"El numero {num2} es el mayor");
            }
            else
            {
                Console.WriteLine($"El numero {num3} es el mayor");
            }
        }
    }
}