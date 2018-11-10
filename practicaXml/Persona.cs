using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaXml
{
    public class Persona
    {
        public static List<Persona> lista=new List<Persona>();
        public string nombre;
        public Persona()
        {

        }
        public Persona(string n)
        {
            this.nombre = n;
        }
    }
}
