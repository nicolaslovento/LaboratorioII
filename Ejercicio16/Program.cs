using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Nicolas", "Rodriguez", 190);
            Alumno alumno2 = new Alumno("Roberto", "Jaime", 191);
            Alumno alumno3 = new Alumno("Micke", "Jhonson", 192);

            alumno1.Estudiar(6, 7);
            alumno2.Estudiar(1, 1);
            alumno3.Estudiar(5, 3);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();
            Console.ReadKey();
        }
    }
}
