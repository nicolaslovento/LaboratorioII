using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
  public class Comercial:Avion,IARBA
  {
    private int _capacidadPasajeros;

    public Comercial(double precio,double velocidad,int pasajeros) : base(precio, velocidad)
    {
      this._capacidadPasajeros = pasajeros;
    }

    public double CalcularImpuesto()
    {
      return (this._precio * 25) / 100;
    }
  }
}
