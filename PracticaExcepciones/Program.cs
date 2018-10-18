using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un numero: ");
                int num1 = int.Parse(Console.ReadLine());
                Calcular(num1);
            }
            catch (OverflowException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (DivideByZeroException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (MiException r)
            {
                Console.WriteLine(r.Message);
            }

            Console.WriteLine("asd");
            Console.Read();


        }

        static void Calcular(int num)
        {
            if (num < 5)
            {
                throw new MiException();
            }
        }
    }
}
