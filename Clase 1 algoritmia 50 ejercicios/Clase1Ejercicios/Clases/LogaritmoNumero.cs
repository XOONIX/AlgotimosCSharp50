using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    internal class LogaritmoNumero
    {
        public static void Ejecutar()
        {
            int num, log;
            Console.WriteLine("Ingresa un numero: ");
            num = int.Parse(Console.ReadLine());
            log = 0;
            for (int i = 1; i <= 10; i++) 
            {
                log = i * (num * num);
                Console.WriteLine(log);
            }
            
        }
    }
}
