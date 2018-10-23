using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaExcepcion:Exception
    {
        public UnaExcepcion(string msj,Exception e):base(msj,e)
        {

        }

    }
}
