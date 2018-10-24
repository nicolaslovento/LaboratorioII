using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCocinas;
using EntidadesEj16;


namespace PruebaGenericaClase16
{
    public class Class1
    {
    
      Cocina c1 = new Cocina(111, 12300, false);
    Cocina c2 = new Cocina(112, 15000, true);
    Cocina c3 = new Cocina(113, 5600, false);
    Auto a1 = new Auto("Rojo", "Ferrari");
    Auto a2 = new Auto("Amarillo", "Porche");
    Auto a3 = new Auto("Negro", "BMW");
    Auto a4 = new Auto("Verde", "Ford");
    
    Depositos<Cocina> dc = new Depositos<Cocina>(5);
    Depositos<Auto> da = new Depositos<Auto>(3);
    
    

    dc.Agregar(c2);
    if (!(dc + c3))
    {
    Console.WriteLine("No se pudo agregar el item!!!");
    }
    if ((da + a1))
{
Console.WriteLine("Se ha agregado el item!!!");
}
da.Agregar(a2);
da.Agregar(a3);
if (!da.Agregar(a4))
{
Console.WriteLine("No se pudo agregar el item!!!");
}
Console.WriteLine(dc);
Console.WriteLine(da);
dc.Remover(c2);
if (!(dc - c2))
{
Console.WriteLine("No se pudo remover el item!!!");
}
da.Remover(a2);
if (!(da - a4))
{
Console.WriteLine("No se pudo remover el item!!!");
}
  Console.WriteLine(dc);
  Console.WriteLine(da);

  Console.ReadLine();
}
      
    }

