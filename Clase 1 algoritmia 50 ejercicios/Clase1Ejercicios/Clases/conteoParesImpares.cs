using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ejercicios.Clases
{
    class conteoParesImpares
    {
        public static void Ejecutar()
        {
                
            int cantidadNumeros, pares, impares, nNumeros, numero;

            Console.WriteLine("Cuantos valores desea contar: ");
            nNumeros = int.Parse(Console.ReadLine());
            pares = 0;
            impares = 0;
            for (int i = 0; i <= nNumeros - 1; i++) {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares = pares + 1;
                }
                else {
                    impares = impares + 1;
                }
            }
            cantidadNumeros = impares + pares;
            Console.WriteLine($"El total de numeros consultados es de {cantidadNumeros} \n" +
                $"El total de numeros pares es de {pares}\n" +
                $"Y el total de numeros impares es de {impares}");


        }
    }            
}