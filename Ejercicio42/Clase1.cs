using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Clase1
    {

        public Clase1()
        {
            try
            {
                Dividir();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Dividir()
        {
            throw new DivideByZeroException();
        }
    }
}
