using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {/*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.
        */
        static void Main(string[] args)
        {
            int numero;
            int acumulador=0;
            char letra;
            do
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                Console.WriteLine("{0}", acumulador);

                Console.Write("Desea Seguir? S/N: ");
                letra = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidarS_N(letra) == true);

        }
    }
}
