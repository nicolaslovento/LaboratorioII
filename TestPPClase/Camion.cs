using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPPClase
{
  public class Camion:Vehiculo
  {
    protected float _tara;

    public Camion(string patente, Byte ruedas, EMarcas marca,float tara) : base(patente, ruedas, marca)
    {
      this._tara = tara;
    }

    public Camion(Vehiculo v,float tara) : this(v.Patente,v.Ruedas,v.Marca,tara)
    {
      
    }

    protected override string Mostrar()
    {
      string info;
      info = base.Mostrar() + "Tara: " + this._tara+"\n";
      return info;
    }

    public override string ToString()
    {
      return Mostrar();
    }

  }
}
