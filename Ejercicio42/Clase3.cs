using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Clase3
    {
        public Clase3()
        {
            try
            {
                new Clase2();//lanza exeception DividePorZero
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Capturo: "+e.Message+"y lanzo Exception UnaExcepcion..\n",e);
            }
        }

    }
}
