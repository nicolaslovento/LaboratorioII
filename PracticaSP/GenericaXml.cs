using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace PracticaSP
{
    public class GenericaXml<T> : IArchivo<T>
    {
        public bool Guardar(string path, T lista)
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            XmlTextWriter xmlWri = new XmlTextWriter(path,Encoding.UTF8);
            bool retorno = false;
            try
            {
                xmlSer.Serialize(xmlWri, lista);
                retorno = true;
            }
            catch (Exception)
            {

            }

            finally
            {
                if (retorno = true)
                {
                    xmlWri.Close();
                }
            }

            return retorno;

        }

         public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;

            XmlTextReader r = null;
            XmlSerializer s = new XmlSerializer(typeof(T));
            datos = default(T);
            try
            {
                r = new XmlTextReader(archivo);
                datos = (T)s.Deserialize(r);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (!(r is null))
                {
                    r.Close();
                    retorno = true;
                }
            }

            return retorno;
        }
    }
}
