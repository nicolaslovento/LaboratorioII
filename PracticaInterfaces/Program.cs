using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(100);


            Console.WriteLine(v1.AplicarImpuestoNacinal);

            Console.ReadKey();


        }
    }
}
