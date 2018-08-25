using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/
        static void Main(string[] args)
        {
            int numero;
            double numCuadrado;
            double numCubo;
            Boolean esNumero;

            Console.Write("Ingresar numero: ");
            esNumero = int.TryParse(Console.ReadLine(), out numero);

            while (esNumero != true || numero < 0)
            {
                Console.Write("ERROR, reingresar numero! : ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
            }

            numCuadrado = Math.Pow(numero, 2);
            numCubo = Math.Pow(numero, 3);
            Console.Write("Numero cuadrado: {0} Numero cubo: {1}",numCuadrado,numCubo);

            Console.Read();

        }
    }
}
