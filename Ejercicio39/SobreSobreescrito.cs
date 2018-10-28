using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class SobreSobreescrito : SobreescritoAbs
    {
        public override string MiPropiedad { get { return this._miAtributo; } }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
