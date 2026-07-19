using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    internal class IMC
    {
        public static void Ejecutar() {
            float altura, peso, IMC;
            Console.Write("Ingrese la altura en m: ");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso en kilos: ");
            peso = float.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            Console.WriteLine($"El IMC es de {IMC}");
                }
    }
}
