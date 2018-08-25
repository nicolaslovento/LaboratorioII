using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.Write("Ingrese año: ");
            bool esNumero = int.TryParse(Console.ReadLine(), out año);

            if (esNumero)
            {
                if (año % 4 == 0)
                {
                    if (año % 100 == 0)
                    {
                        if (año % 400 == 0)
                        {
                            Console.WriteLine("{0} Es bisiesto!",año);
                        }
                        else
                        {
                            Console.WriteLine("{0} NO es bisiesto!", año);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} Es bisiesto!", año);
                    }
                }
                else
                {
                    Console.WriteLine("{0} NO es bisiesto!", año);
                }
            }

            Console.ReadKey();
        }
    }
}
