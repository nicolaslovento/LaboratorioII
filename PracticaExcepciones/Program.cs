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
                try
                {
                    try
                    {
                        Calcular();
                    }
                    catch (MiException e)
                    {
                        throw new Exception(e.Message + " Lanzo excepcion..", e);

                    }
                }
                catch (Exception e)
                {
                    throw new DivideByZeroException(e.Message + " Lanzo divideByZero..", e);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            


            Console.ReadKey();

        }

        static void Calcular()
        {
            
                throw new MiException("Error en metodoCalcular");
            
        }
    }
}
