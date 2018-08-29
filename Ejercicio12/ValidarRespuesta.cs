using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char letra)
        {
            if(letra=='S' || letra=='s')
            {
                return true;
            }

            return false;
        }
    }
}
