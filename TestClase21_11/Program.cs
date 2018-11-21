using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesClase21_11;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace TestClase21_11
{
  public class Program
  {
    static void Main(string[] args)
    {
      Persona p1 = new Persona("Nicolas", "Lo Vento", 24, EntidadesClase21_11.ESexo.Masculino);

      Console.WriteLine("{0},{1},{2},{3}", p1.Nombre, p1.Apellido, p1.Edad, p1.Sexo);
      Console.WriteLine(p1.ObtenerDatos());
      Console.WriteLine(p1.EsNulo());
      
      Console.WriteLine(p1.EsNulo());
      //Clase externa

      //PersonaExternaHeredada e1 = new PersonaExterna("Roberto","Nando",55,Entidades.Externa.ESexo.Masculino);

      //PersonaExternaHeredada peh = new PersonaExternaHeredada("Maria", "Jua", 33, Entidades.Externa.ESexo.Femenino);
      //Console.WriteLine(peh.ObtenerDatos());

      //metodo de extension

      PersonaExternaSellada p2 = new PersonaExternaSellada("Maria", "Jua", 33, Entidades.Externa.Sellada.ESexo.Femenino);

      Console.WriteLine(p2.ObtenerDatos());
      Console.WriteLine(p2.EsNulo());


      Int32 num =50;

      Console.WriteLine(Extensora.CantidadDigitos(332133));

      Console.WriteLine(num.TieneLaMismaCantidad(22));






      if (p1.AgregarDb())
      {
        Console.WriteLine("Se agrego con exito..");
      }
      else
      {
        Console.WriteLine("No se pudo agregar..");
      }



      List<Persona> newList= Persona.TraerTodos();
      Console.WriteLine("Cantidad de personas: "+newList.Count);
      foreach (Persona p in newList)
      {
        Console.WriteLine(p.ObtenerDatos());
        
      }
      


      Console.ReadLine();



    }
  }
}
