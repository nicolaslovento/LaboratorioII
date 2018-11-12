using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiException:Exception
    {

        public MiException(string msj, Exception e) : base(msj, e)
        {

        }

    }
}
