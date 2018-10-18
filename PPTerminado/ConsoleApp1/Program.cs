using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor a1 = new Autor("Domingo", "Caballo");
            Autor a2 = new Autor("Esteban", "Rey");
            Autor a3 = new Autor("Joe", "Mayo");

            Manual m1 = new Manual("Economia", (float)25.66, "Domingo", "Caballo", Etipo.Finanzas);
            Novela n1 = new Novela("Miseria",(float) 63.88, a2, EGenero.Romantica);
            Manual m2 = new Manual("C#", (float)29.95, "Joe", "Mayo", Etipo.Tecnico);
            Novela n2 = new Novela("Miseria", 203, a2, EGenero.Accion);
            Novela n8 = new Novela("Miseria", 98, a2, EGenero.CienciaFiccion);
            Novela n3 = new Novela("Miseria", 98, a2, EGenero.CienciaFiccion);
            Novela n6 = new Novela("asdfas", 98, a1, EGenero.CienciaFiccion);


            Biblioteca b;
            b = 5;

            b += m1;
            b += n1;
            b += n3;
            b += m2;
            b += n8;//Repetido
            b += n2;
            b += n6;//No hay lugar
            
            Console.WriteLine(Biblioteca.Mostrar(b));
            Console.ReadKey();


        }
    }
}
