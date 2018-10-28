using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        /*Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de
cero de forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente.*/
        static void Main(string[] args)
        {
            Random rm = new Random();
            int[] numeros=new int[20];
            
            for(int n = 0; n < 20; n++) { 

                numeros[n] = rm.Next(-100, 100);
            }

            Mostrar(numeros);
            ordenarPositivos(numeros);
            ordenarNegativos(numeros);
            Console.ReadKey();

        }


        static void ordenarNegativos(int[] numeros)
        {
            Console.WriteLine("*** NEGATIVOS ORDENADOS***");

            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }

        static void ordenarPositivos(int []numeros)
        {
            Console.WriteLine("*** POSITIVOS ORDENADOS***");

            Array.Sort(numeros);

            for (int i = 0; i < numeros.Length ; i++)
            {
                if (numeros[i] > 0)
                { 
                    Console.WriteLine(numeros[i]);
                }
            }
        }

        static void Mostrar(int [] numeros)
        {
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
