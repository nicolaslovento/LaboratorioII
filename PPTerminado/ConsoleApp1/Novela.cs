using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum EGenero { Accion,Romantica,CienciaFiccion}
    class Novela:Libro
    {
        public EGenero _genero;

        public Novela(string titulo,float precio,Autor autor,EGenero genero) : base(titulo, autor, precio) { 


                this._genero = genero;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            sb.AppendLine("Genero " + this._genero);
            return sb.ToString();
        }

        public static implicit operator double(Novela n)
        {
            return n._precio;
        }

        public static bool operator ==(Novela n1,Novela n2)
        {
            if((Libro)n1==(Libro)n2 && n1._genero == n2._genero)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }



    }
}
