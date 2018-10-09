using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPPClase
{
  public class Auto : Vehiculo
  {
    protected int _cantidadDeAsientos;

    public Auto(string patente,Byte ruedas,EMarcas marca,int asientos) : base(patente,ruedas,marca)
    {
      this._cantidadDeAsientos = asientos;
    }

    public Auto(string patente,EMarcas marca,int asientos):this(patente,4,marca,asientos)
    {
      
    }

    protected override string Mostrar()
    {
      string info;
      info = base.Mostrar()+" Cant de asientos: "+this._cantidadDeAsientos;
      return info;
    }

    public override string ToString()
    {
      return Mostrar();
    }


  }
}
