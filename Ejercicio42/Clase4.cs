using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Clase4
    {
        public void MetodoInstancia()
        {
            try
            {
                new Clase3();
            }
            catch (UnaExcepcion e)
            {
                throw new MiException("\nMsj ANterior: "+e.Message+" y lanzo MiException\n",e);
            }
        }
    }
}
