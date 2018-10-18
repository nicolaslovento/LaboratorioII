using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Etipo { Tecnico,Escolar,Finanzas}

    class Manual: Libro
    {
        private Etipo _tipo;

        public Manual(string titulo,float precio,string nombre,string apellido,Etipo tipo):base(precio,titulo,nombre,apellido)
        {
            this._tipo = tipo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendLine("Tipo " + this._tipo);
            return sb.ToString();
        }

        public static implicit operator double (Manual m)
        {
            return m._precio;
        }

        public static bool operator ==(Manual m1,Manual m2)
        {
            if((Libro)m1==(Libro)m2 && m1._tipo == m2._tipo)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }


    }
}
