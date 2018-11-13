using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaXml.cs
{
    public class Persona
    {
        public string nombre;
        public int edad;

        public Persona()
        {

        }

        public Persona(string nombre,int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
