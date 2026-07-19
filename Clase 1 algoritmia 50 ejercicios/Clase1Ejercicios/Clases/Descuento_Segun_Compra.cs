using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class Descuento_Segun_Compra
    {
        public static void Ejecutar()
        {
            decimal descuento, compra, total;
            Console.Write("Ingrese el valor de su compra: ");
            compra = decimal.Parse(Console.ReadLine());
            if (compra > 0)
            {
                if (compra >= 20 && compra < 50)
                {
                    descuento = compra * 0.10m;
                    total = compra - descuento;
                    Console.WriteLine($"El total de su compra es de ${total}");
                }
                else if (compra >= 50 && compra < 100)
                {
                    descuento = compra * 0.25m;
                    total = compra - descuento;
                    Console.WriteLine($"El total de su compra es de ${total}");
                }
                else if (compra >= 100 && compra < 180)
                {
                    descuento = compra * 0.50m;
                    total = compra - descuento;
                    Console.WriteLine($"El total de su compra es de ${total}");
                }
                else { Console.WriteLine("No tiene descuento"); }
            }
        }
    }

}