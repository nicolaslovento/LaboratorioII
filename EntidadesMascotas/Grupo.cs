using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{   
    public enum TipoManada { Unica,Mixta};
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static TipoManada _tipo;

        public TipoManada Tipo { set { Grupo._tipo = value; } }

        #region CONSTRUCTORES
        static Grupo()
        {
            _tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this._manada=new List<Mascota>();
        }

        public Grupo(string nombre):this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre,TipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        public static implicit operator string (Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**" + g._nombre+"**");
            sb.AppendLine("Integrantes:");
            foreach (Mascota m in g._manada)
            {
                sb.AppendLine(m.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Grupo g,Mascota m)
        {
            foreach(Mascota l in g._manada)
            {
                if (m.Equals(l) || m.Equals(l))
                {
                    return true;
                }
                
            }

            return false;

        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.RemoveAt(g._manada.IndexOf(m));
            }

            return g;
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g._manada.Add(m);
            }

            return g;
        }


    }
}
