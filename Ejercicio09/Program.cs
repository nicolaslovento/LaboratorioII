using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    { /*Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
        */
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese altura de la piramide: ");
            numero = int.Parse(Console.ReadLine());
            
            while(numero<=0)
            {
                Console.Write("Ingrese altura de la piramide (Mayor a 0): ");
                numero = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < 1 + i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
            Console.Read();
        }
    }
}
