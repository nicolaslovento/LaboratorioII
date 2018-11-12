using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Clase4 c = new Clase4();
                c.MetodoInstancia();
            }
            catch (MiException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }


        
    }
}
