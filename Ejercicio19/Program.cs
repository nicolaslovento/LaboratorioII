using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum1 = new Sumador(3);
            Sumador sum2 = new Sumador(4);

            long resultado=sum1.Sumar(2, 5);
            Console.WriteLine("Suma: {0} Cantidad de sumas: {1}", resultado,(int)sum1);

            resultado=sum1 + sum2;
            Console.WriteLine("Suma entre los dos: {0}", resultado);

            bool igual = sum1 | sum2;
            Console.WriteLine("Son iguales?\n{0}", igual);

            Console.ReadKey();
        }
    }
}
