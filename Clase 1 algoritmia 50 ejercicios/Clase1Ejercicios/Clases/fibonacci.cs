using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases { }
public class Fibonacci
{
    public static void Ejecutar()
    {
        int n = 10; // Cantidad de números a generar
        int a = 0, b = 1, c;

        Console.Write("Serie de Fibonacci: " + a + ", " + b);

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(", " + c);
            a = b;
            b = c;
        }
    }
}