using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public string Nombre { get { return this._nombre; } }
        public string Raza { get { return this._raza; } }

        public Mascota(string nombre,string raza)
        {
            this._nombre = nombre;
            this._raza = raza;

        }

        protected virtual string  DatosCompletos()
        {
            return String.Format("{0}  {1}", this._nombre, this._raza);
        }

        protected abstract string Ficha();
        


    }
}
