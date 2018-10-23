using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCocinas
{
  public class Cocina
  {
    private int _codigo;
    private bool _esIndustrial;
    private double _precio;

    public int Codigo { get { return this._codigo; } }
    public bool EsIndustrial { get { return this._esIndustrial;} }
    public double Precio { get { return this._precio; } }

    public Cocina(int codigo,double precio,bool esIndustrial)
    {
      this._codigo = codigo;
      this._precio = precio;
      this._esIndustrial = esIndustrial;
    }

    public override bool Equals(object obj)
    {
      if(obj is Cocina)
      {
        Cocina c = (Cocina)obj;
        if (this._codigo == c._codigo)
        {
          return true;
        }
      }

      return false;
    }

    public static bool operator ==(Cocina a, Cocina b)
    {
      if (a._codigo == b._codigo)
      {
        return true;
      }

      return false;
    }

    public static bool operator !=(Cocina a, Cocina b)
    {
      return !(a == b);
    }

    

    public override string ToString()
    {
      return "Codigo: " + this._codigo + " Precio: " + this._precio+" Industrial: "+this._esIndustrial;
    }

    

  }
}
