using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
  public class Carreta:Vehiculo,IARBA
  {

    public Carreta(double precio):base(precio)
    {

    }


    public double CalcularImpuesto()
    {
      return (this._precio * 18) / 100;
    }

    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio carreta: " + this._precio);
    }

    public double ImpuestoIARBA
    {

      get
      {
        return ((IARBA)this).CalcularImpuesto();
      }
    }

  }
}
