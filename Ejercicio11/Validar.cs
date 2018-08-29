using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validar
    {
        public static bool ValidarNumero(int valor,int min,int max)
        {
            if(valor<min || valor > max)
            {
                return false;
            }

            return true;
        }
    }
}
