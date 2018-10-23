using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Clase2
    {
        public void MetodoDeInstancia()
        {
            try
            {
                new Clase1();
            }
            catch (Exception e)
            {
                throw new UnaExcepcion(e.Message + "Error Metodo clase 2", e);
            }
        }

    }
}
