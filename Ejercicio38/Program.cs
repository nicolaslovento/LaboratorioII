using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Program
    {
        /*Crear una clase llamada Sobreescrito dentro de un proyecto de Consola:
a. Sobreescribir el método ToString para que retorne "¡Este es mi método ToString
sobreescrito!".
b. Sobreescribir el método Equals para que retorne true si son del mismo tipo (objetos de la
misma clase), false en caso contrario.
c. Sobreescribir el método GetHashCode para que retorne el número 1142510187*/
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nº38 Guía 2017";
            Sobreescrito sobrecarga = new Sobreescrito();
            Console.WriteLine(sobrecarga.ToString());
            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
