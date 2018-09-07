using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Program
  {
    static void Main(string[] args)
    {
      Tinta t1 = new Tinta();
      Tinta t2 = new Tinta(ConsoleColor.Blue);//creo tinta

      Pluma p1 = new Pluma("FaberCastell",5, t1);//creo pluma

      Console.WriteLine(p1);//muestro pluma implicitamente

      

      Console.WriteLine(Tinta.MostrarEst(t1));//muestro tinta con metodo estatico
      
      if (t1==t2)//comparo con sobrecarga de operadores == & !=
      {
        Console.WriteLine("Son iguales.");
      }else
      {
        Console.WriteLine("Son distintos.");
      }


      if(p1==t2)//comparo implicitamente la tinta con la q contiene la pluma
      {
        Console.WriteLine("La tinta es igual a la que contiene la pluma.");
      }
      else
      {
        Console.WriteLine("Son distintos.");
      }

      Pluma p2 = new Pluma();

      if(p2+t1)
      {
        Console.WriteLine("Se agrego tinta a la pluma.");
      }else
      {
        Console.WriteLine("La tinta es diferente a la pluma.No se puedo agregar.");
      }

      if (p2 - t1)
      {
        Console.WriteLine("Se quito tinta a la pluma.");
      }
      else
      {
        Console.WriteLine("La tinta es diferente a la pluma.No se puedo quitar.");
      }

      Console.WriteLine(p2);


      Console.ReadKey();

    }
  }
}
