using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarreraAnimales
{
    public class Caballo:Animal
    {
        protected static int _patas;
        protected string _nombre;


        static Caballo()
        {
            Caballo._patas = 4;
        }

        public Caballo(string nombre,int velocidadMaxima) : base(Caballo._patas, velocidadMaxima)
        {
            this._nombre = nombre;
        }

        

        public string MostrarCaballo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Nombre: " + this._nombre);

            return sb.ToString();
        }


        public static bool operator ==(Caballo h1, Caballo h2)
        {
            if (h1._nombre == h2._nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Caballo h1,Caballo h2)
        {
            return !(h1 == h2);
        }


    }
}
