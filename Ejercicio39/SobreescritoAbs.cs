using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    abstract class SobreescritoAbs
    {

        protected string _miAtributo;

        public SobreescritoAbs()
        {
            this._miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();
        
        
    }
}
