using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class Sobreescrito
    {
        public override string ToString()
        {
            return "Este es mi metodo ToString() sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            if (obj==this)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
