using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace PracticaXml.cs
{
    public class XmlGenerica<T>
    {
        public bool GuardarEnXml(string archivo,List<T> lista)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<T>));
            XmlTextWriter xmlWri = new XmlTextWriter(archivo, Encoding.UTF8);
            bool retorno = false;
            try
            {
                xmlSer.Serialize(xmlWri, lista);
                retorno = true;
                xmlWri.Close();
            }
            catch (Exception)
            {

            }

            return retorno;

        }

        public  List<T> LeerEnXml(string archivo)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<T>));
            XmlTextReader xmlReader = new XmlTextReader(archivo);

            List<T> nuevaLista = new List<T>();

            try
            {
                nuevaLista = (List<T>)xmlSer.Deserialize(xmlReader);

            }
            catch (Exception)
            {

            }

            return nuevaLista;

        }
    }
}
