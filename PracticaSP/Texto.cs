using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticaSP
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string path, string texto)
        {
            StreamWriter sr = new StreamWriter(path);
            bool retorno = false;
            try
            {
                sr.WriteLine(texto);
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }

            finally
            {
                sr.Close();
            }

            return retorno;

        }

        public bool Leer(string path, out string datos)
        {
            StreamReader sr = new StreamReader(path);
            bool retorno = false;
            datos = "";
            try
            {
                datos=sr.ReadToEnd();
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }

            finally
            {
                sr.Close();
            }

            return retorno;
        }
    }
}
