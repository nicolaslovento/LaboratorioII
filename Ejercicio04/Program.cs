using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
        static void Main(string[] args)
        {
            
            int numerosPerfectos=0;
            int sumador = 0;
            

            for(int i=2;numerosPerfectos<4;i++)
            {

                for(int j=1;j<i;j++)
                {
                    if(i%j==0)
                    {
                        sumador = sumador + j;
                    }
                }

                if (i == sumador)
                {
                    Console.Write("{0}\n", i);
                    
                }
                sumador = 0;

            }

            Console.Read();

        }
    }
}
