using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarreraAnimales
{
    
    public class Perro:Animal
    {
        public enum Razas { Galgo, OvejeroAleman }


        protected static int _patas;
        protected Razas _raza;


        static Perro() {
            Perro._patas = 4;
        }

        public Perro(int velocidadMaxima) : base(Perro._patas, velocidadMaxima)
        {
            
        }

        public Perro(Razas raza,int velocidadMaxima):base(Perro._patas,velocidadMaxima)
        {
            this._raza = raza;
        }

        public string MostrarPerro()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Razas: " + this._raza);

            return sb.ToString();
        }

        public static bool operator ==(Perro h1, Perro h2)
        {
            if (h1._raza == h2._raza && h1._velocidadMaxima== h2._velocidadMaxima)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Perro h1, Perro h2)
        {
            return !(h1 == h2);
        }


    }
}
