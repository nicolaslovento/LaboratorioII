using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCarreraAnimales;

namespace TestCarreraAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera carrera = new Carrera(10);
            
            Animal a1 = new Perro(Perro.Razas.Galgo, 155);
            carrera += a1;
            Perro a2 = new Perro(Perro.Razas.Galgo, 60);
            carrera += a2;
            Humano a3 = new Humano("Juan", "Gomez", 20);
            carrera += a3;
            Caballo a4 = new Caballo("Veloz", 70);
            carrera += a4;
            Caballo a5 = new Caballo("Match 5", 75);
            carrera += a5;
            Animal a6 = new Humano("Pedro", "Martínez", 40);
            carrera += a6;
            Perro a7 = new Perro(Perro.Razas.OvejeroAleman, 50);
            carrera += a7;


            Console.WriteLine(carrera.MostrarCarrera(carrera));

            Console.ReadKey();

        }
    }
}
