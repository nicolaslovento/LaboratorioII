using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSP
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Auto> listaAutos=new List<Auto>();
            List<Camion> listaCamiones = new List<Camion>();

            Auto a1 = new Auto("Fiat", 4, ConsoleColor.Black, 4);
            Auto a2 = new Auto("Ferrari", 3, ConsoleColor.Red, 4);
            Auto a3 = new Auto("Fiat", 4, ConsoleColor.White, 3);
            Auto a4 = new Auto("Peugeot", 4, ConsoleColor.Blue, 5);
            Camion c1 = new Camion("Fiat", 4, ConsoleColor.Black, 4);
            Camion c2 = new Camion("Fiat", 4, ConsoleColor.Black, 4);
            Camion c3 = new Camion("Fiat", 4, ConsoleColor.Black, 4);
            Camion c4 = new Camion("Fiat", 4, ConsoleColor.Black, 4);

            listaAutos.Add(a1);
            listaAutos.Add(a2);
            listaAutos.Add(a3);
            listaAutos.Add(a4);
            listaCamiones.Add(c1);
            listaCamiones.Add(c2);
            listaCamiones.Add(c3);


            GenericaXml<List<Auto>> xmlAutos = new GenericaXml<List<Auto>>();
            string ubi = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Autos.xml";

            if(xmlAutos.Guardar(ubi, listaAutos))
            {
                Console.WriteLine("Se guardo la lista xml de autos..");
            }

            Console.ReadKey();

            List<Auto> listaRetorno;
            if (xmlAutos.Leer(ubi,out listaRetorno))
            {
                Console.WriteLine("Se leyo la lista xml de autos..");
            }

            string datos = "";
            foreach(Auto a in listaAutos)
            {
                datos += a.Mostrar();
            }

            ubi = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\AutosEnTexto.txt";

            Texto texto = new Texto();

            texto.Guardar(ubi, datos);

            string lectura = "";
            texto.Leer(ubi,out lectura);
            Console.WriteLine(lectura);
            Console.ReadKey();


        }
    }
}
