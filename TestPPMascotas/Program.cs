using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesMascotas;
namespace TestPPMascotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mascota p1 = new Perro("Moro","Pitbull");
            Mascota p2 = new Perro("Julio", "Cruza",13,false);
            Mascota p3 = new Perro("Ramon", "Salchicha", 2, true);
            Mascota g1 = new Gato("Jose", "Angora");
            Mascota g2 = new Gato("Hernan", "Cruza");

            Grupo lista = new Grupo("Rio Unica");
            lista += p1;
            lista += p2;
            lista += p3;
            lista += g1;
            lista += g2;


            Console.WriteLine(lista);
            Console.ReadKey();


        }
    }
}
