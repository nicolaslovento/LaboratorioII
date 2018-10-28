using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarreraAnimales
{
    public class Humano:Animal
    {

        protected static int _piernas;
        protected string _nombre;
        protected string _apellido;


        static Humano()
        {
            Humano._piernas = 2;
        }

        public Humano(int velocidadMaxima) : base(Humano._piernas, velocidadMaxima)
        {
            this._velocidadMaxima = velocidadMaxima;
        }

        public Humano(string nombre,string apellido, int velocidadMaxima) : base(Humano._piernas, velocidadMaxima)
        {
            this._velocidadMaxima = velocidadMaxima;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Nombre y apellido: " + this._nombre +" "+ this._apellido);

            return sb.ToString();
        }

        public static bool operator ==(Humano h1,Humano h2)
        {
            if(h1._nombre==h2._nombre && h1._apellido == h2._apellido)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }

    }
}
