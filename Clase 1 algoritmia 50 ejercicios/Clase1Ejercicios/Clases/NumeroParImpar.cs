using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class NumeroParImpar
    {
        public static void Ejecutar()
        {
            int par, impar, numero;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar");
            }
        }
    }

}