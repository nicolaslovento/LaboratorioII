using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioInterfaces;

namespace TestEjercicioInterfaces
{
  public class Program
  {
    static void Main(string[] args)
    {
      Deportivo d1 = new Deportivo(150000, "ACS222", 450);
      Familiar f1 = new Familiar(12000, "FDS123", 4);
      Privado p1 = new Privado(100, 1232, 10);
      Comercial c1 = new Comercial(3333333, 213, 100);
      Carreta carreta1 = new Carreta(123412);

      d1.MostrarPrecio();
      d1.MostrarPatente();


      f1.MostrarPatente();

      Console.WriteLine(p1.Impuesto);
      Console.WriteLine(p1.ImpuestoIARBA);
      p1.
      Console.WriteLine(Gestion.MostrarImpuestoNacional(p1));

      Console.ReadLine();
    }
  }
}
