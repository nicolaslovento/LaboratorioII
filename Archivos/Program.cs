using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
  class Program
  {
    static void Main(string[] args)
    {

      //MIS DOCUMENTOS
      if(AdministradorArchivos.Escribir(@"D:\\Mis Documentos\\texto.txt", "Hola asd dsf sd f"))
      {
        Console.WriteLine("Se escribio el archivo guardado en Mis Documentos.");
      }else
      {
        Console.WriteLine("NO se escribio el archivo guardado en Mis Documentos.");
      }

      string lectura;
      if(AdministradorArchivos.Leer(@"D:\\Mis Documentos\\texto.txt",out lectura))
      {
        Console.WriteLine("Se pudo leer:");
        Console.WriteLine(lectura);
      }
      else
      {
        Console.WriteLine("NO se puedo leer.");
      }

      //ESCRITORIO

      /*

      appDomain.CurrentDomain.BaseDirectory
       */

      //AppDomain.CurrentDomain.BaseDirectory;
      string a;
      a = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\texto.txt";
      Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
      if (AdministradorArchivos.Escribir(a, "Hola asd dsf sd f"))
      {
        Console.WriteLine("Se escribio el archivo guardado en Escritorio.");
      }
      else
      {
        Console.WriteLine("NO se escribio el archivo guardado en Escritorio.");
      }

      string lectura1;
      if (AdministradorArchivos.Leer(a, out lectura1))
      {
        Console.WriteLine("Se pudo leer:");
        Console.WriteLine(lectura1);
      }
      else
      {
        Console.WriteLine("NO se puedo leer.");
      }




      Console.ReadLine();

    }
  }
}
