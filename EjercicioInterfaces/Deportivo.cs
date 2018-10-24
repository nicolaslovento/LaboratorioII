using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
  public class Deportivo:Auto,IAFIP,IARBA
  {
    private int _caballosFuerza;

    public Deportivo(double precio,string patente,int hp) : base(precio, patente)
    {
      this._caballosFuerza = hp;
    }

    public double CalcularImpuesto()
    {
      return (this._precio * 28) / 100;
    }

    double IARBA.CalcularImpuesto()
    {
      return (this._precio * 23) / 100;
    }

    public override void MostrarPatente()
    {
      Console.WriteLine("Patente deportivo: " + this._patente);
    }
    public override void MostrarPrecio()
    {
      Console.WriteLine("Precio deportivo: " + this._precio);
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
