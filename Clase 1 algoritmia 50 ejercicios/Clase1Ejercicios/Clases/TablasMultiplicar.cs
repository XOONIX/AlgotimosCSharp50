using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    internal class TablasMultiplicar

    {
        public static void Ejecutar()
        {

            int numero, tabla;
            Console.Write("Inserta un numero, para conocer su tabla: ");
            numero = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                tabla = numero * i;
                Console.WriteLine($"{numero}x{i}={tabla}");  
            }
        }
    }
}
