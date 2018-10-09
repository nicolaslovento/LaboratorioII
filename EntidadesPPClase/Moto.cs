using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPPClase
{
  public class Moto:Vehiculo
  {
    protected float _cilindrada;

    public Moto(string patente, Byte ruedas, EMarcas marca,float cilindrada) : base(patente, ruedas, marca)
    {
      this._cilindrada = cilindrada;
    }

    public Moto(EMarcas marca,float cilindrada,string patente,Byte ruedas) : this(patente, ruedas, marca,cilindrada)
    {
      
    }

    protected override string Mostrar()
    {
      string info;
      info = base.Mostrar() + " Cilindrada: " + this._cilindrada;
      return info;
    }

    public override string ToString()
    {
      return Mostrar();
    }
  }
}
