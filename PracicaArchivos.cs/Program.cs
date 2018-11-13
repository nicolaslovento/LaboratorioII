using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PracicaArchivos.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto= "Hola mundo frg fgh fd h fhdfhasd";
            string ubicacion;
            ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\texto.txt";

            StreamWriter sw = new StreamWriter(ubicacion, false);//true agrega false sobreescriba

            try
            {
                sw.WriteLine(texto);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo escribir el archivo");
            }

            finally
            {
                sw.Close();

            }

            Console.WriteLine("Ahora vamos a leerlo..");
            Console.ReadKey();

            StreamReader Sr = new StreamReader(ubicacion);
            string lectura="";

            try
            {
                lectura=Sr.ReadToEnd();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Sr.Close();
            }

            Console.WriteLine(lectura);
            Console.Read();

        }
    }
}
