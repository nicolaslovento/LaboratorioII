using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace practicaXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("jajaa");
            Persona.lista.Add(p);

            
             XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
             XmlTextWriter xmlWriter = new XmlTextWriter("P.xml", Encoding.UTF8);
             XmlTextReader xmlReader = new XmlTextReader("P.xml");

             xmlSerializer.Serialize(xmlWriter, Persona.lista);

             xmlWriter.Close();
               

        }






        }
    }

