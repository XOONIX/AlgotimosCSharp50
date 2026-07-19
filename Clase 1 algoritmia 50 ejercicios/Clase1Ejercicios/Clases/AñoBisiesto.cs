using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class AñoBisiesto
    {
        public static void Ejecutar()
        {
            int año;
            Console.Write("Ingrese el año: ");
            año = int.Parse(Console.ReadLine());
            //(anio % 4 == 0 and anio % 100 != 0) or (anio % 400 == 0)
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else { Console.WriteLine($"El año {año} no es bisiesto"); }
        }
    }

}



