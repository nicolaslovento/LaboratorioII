using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
  static class AdministradorArchivos
  {

    public static bool Escribir(string path,string texto)
    {
      StreamWriter sw;
      sw = new StreamWriter(path, false);
      try
      {
        sw.WriteLine(texto);
        sw.Close();
        return true;
      }
      catch (Exception e)
      {
        return false;
      }

      finally
      {
        sw.Close();
      }
    }

    public static bool Leer(string path, out string texto)
    {
      StreamReader sw;
      
      sw = new StreamReader(path, false);

      try
      {
        texto=sw.ReadToEnd();
          

        return true;
      }
      catch (Exception e)
      {
        texto ="";
        return false;
      }

      finally
      {
        sw.Close();
      }
    }

  }
}
