using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    internal class SumaNumerosHasta11

    {
        public static void Ejecutar()
        {

            int repeticion,suma,numero ;
            Console.Write("Cuantos numeros desea sumar: ");
            repeticion = int.Parse(Console.ReadLine());
            suma = 0;
            for (int i = 1; i <= repeticion; i++)
            {
                Console.Write("Ingrese numero a sumar: ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            }
            Console.WriteLine($"El total de la suma es de {suma}");
        }   


    }
}
