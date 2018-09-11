using System;

namespace EjercicioClase7
{
    class Program
    {
        static void Main(string[] args)
        {
      tempera t1 = new tempera(100,ConsoleColor.Red,"Jaimito");
      tempera t2 = new tempera(100, ConsoleColor.Red, "Jaimito");
      

      Console.WriteLine(t1 +t2);



      Console.ReadKey();


    }
    }
}
