using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Autor
    {
        private string nombre;
        private string apellido;

        public Autor(string n,string a)
        {
            this.apellido = a;
            this.nombre = n;
        }

        public static bool operator ==(Autor a1,Autor a2)
        {
            if(a1.nombre==a2.nombre && a1.apellido == a2.apellido)
            {
                return true;
            }

            return false;
        }

        public static implicit operator string(Autor a)
        {
            return a.nombre +"  "+ a.apellido;
        }

        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }

    }
}
