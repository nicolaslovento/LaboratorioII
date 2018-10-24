using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
  public class Avion: Vehiculo, IAFIP,IARBA
  {
    private double _velocidadMaxima;

    public Avion(double precio,double velMax) : base(precio)
    {
      this._velocidadMaxima = velMax;
    }

    public double CalcularImpuesto()
    {
      return (this._precio*33)/100;
    }

    public override void MostrarPrecio()
    {
      Console.WriteLine("El precio es {0}", this._precio);
    }

    double IARBA.CalcularImpuesto()
    {
      return (this._precio * 27) / 100;
    }

     public double ImpuestoIARBA {

      get
      {
        return ((IARBA)this).CalcularImpuesto();
      }
    }

  }
}
