using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.*/
        static void Main(string[] args)
        {
            int numero;
            int i;
            int contador = 0;
            Console.Write("Ingrese numero: ");
            numero=int.Parse(Console.ReadLine());

            for (i = numero; i > 1; i--)
            {
                for(int j=1; j<=i;j++)
                {
                    if(i%j==0)
                    {
                        contador++;
                    }

                }

                if (contador == 2)
                {
                    Console.Write("{0}\n", i);
                }

                contador = 0;
            }
            Console.Read();
        }
    }
}
