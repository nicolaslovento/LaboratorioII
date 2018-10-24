using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
  public class Familiar:Auto
  {
    private int _cantidadAsientos;

    public Familiar(double precio,string patente,int cantidadAsientos):base(precio,patente)
    {
      this._cantidadAsientos = cantidadAsientos;
    }

    public override void MostrarPatente()
    {
      Console.WriteLine("Patente Familiar: " + this._patente);
    }

    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio Familiar: "+this._precio);
    }

  }
}
