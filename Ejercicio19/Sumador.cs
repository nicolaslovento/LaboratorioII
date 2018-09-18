using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int _cantidadSumas;

        #region CONSTRUCTORES
        public Sumador()
        {
            this._cantidadSumas = 0;
        }

        public Sumador(int n)
        {
            this._cantidadSumas = n;
        }
        #endregion

        #region METODOS

        public long Sumar(long a,long b)
        {
            this._cantidadSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this._cantidadSumas++;

            return String.Concat(a,b);
        }

        public static explicit operator int (Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1,Sumador s2)
        {
            long resultado = s1._cantidadSumas + s2._cantidadSumas;

            return resultado;
        }

        public static bool operator |(Sumador s1,Sumador s2)
        {
            bool retorno = false;
            if (s1._cantidadSumas == s2._cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }



        #endregion
    }
}
