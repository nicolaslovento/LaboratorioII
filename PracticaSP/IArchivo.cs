using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PracticaSP
{
    public interface IArchivo<T>
    {

        bool Guardar(string path, T lista);

        bool Leer(string path ,out T datos);

       

    }
}
