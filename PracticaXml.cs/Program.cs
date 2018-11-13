using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace PracticaXml.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaDePersonas = new List<Persona>();

            Persona p1 = new Persona("Daniel", 15);
            Persona p2 = new Persona("Adrian", 11);
            Persona p3 = new Persona("Sofia", 43);
            Persona p4 = new Persona("Maria", 45);
            Persona p5 = new Persona("Nicolas", 24);

            listaDePersonas.Add(p1);
            listaDePersonas.Add(p2);
            listaDePersonas.Add(p3);
            listaDePersonas.Add(p4);
            listaDePersonas.Add(p5);

            XmlGenerica<Persona> archivo = new XmlGenerica<Persona>();

            if (archivo.GuardarEnXml("PersonasGenerica.xml",listaDePersonas))
            {
                Console.WriteLine("Se guardo con exito..");
            }
            else
            {
                Console.WriteLine("No se pudo guardar..");
            }


            List<Persona> nueva = new List<Persona>();
                
            nueva= archivo.LeerEnXml("PersonasGenerica.xml");

            
            Console.WriteLine(nueva.Count);
            

            Console.ReadKey();






        }

        

        


    }
}
