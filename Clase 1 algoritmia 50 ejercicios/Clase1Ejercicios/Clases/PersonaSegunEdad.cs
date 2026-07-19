using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class PersonaSegunEdad
    {
        public static void Ejecutar()
        {
            int edad;
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad > 0)
            {
                if (edad < 17)
                {
                    Console.WriteLine("Es menor de edad");
                }
                else if (edad > 18 && edad < 30)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else if (edad > 30 && edad < 80)
                {
                    Console.WriteLine("Es un adulto");
                }
                else if (edad > 80 && edad < 105)
                {
                    Console.WriteLine("Esta viejo");
                }
                else if (edad > 105 && edad < 110)
                {
                    Console.WriteLine("¿Estas seguro que tienes esa edad?");
                }
                else
                {
                    Console.WriteLine("El valor excede los limites de vida de un humano");
                }
            }
            else { Console.WriteLine("Edad invalida"); }
        }
    }
}