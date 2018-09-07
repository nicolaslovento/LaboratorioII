using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Pluma
  {
    private string _marca;
    private int _cantidad;
    private Tinta _tinta;

    public Pluma()
    {
      this._marca = "Sin marca";
      this._cantidad = 0;
      this._tinta = null;
    }

    public Pluma(string m,int c,Tinta t)
    {
      this._marca = m;
      this._cantidad = c;
      this._tinta = t;
    }

    private string MostrarPlumaPrivate()
    {
      return this._marca + " " + this._cantidad + " "+Tinta.MostrarEst(this._tinta);
    }

    public static implicit operator string(Pluma pluma)
    {
      return pluma.MostrarPlumaPrivate();
    }

    //true si la tinta es la misma que esta en la pluma
    public static bool operator ==(Pluma pluma, Tinta tinta)
    {
      if (pluma._tinta == tinta)
      {
        return true;
      }
      return false;

    }

    public static bool operator !=(Pluma pluma, Tinta tinta)
    {
      
      return !(pluma._tinta==tinta);

    }

    //operador + entre pluma y una tinta
    // si la tinta q quiero agregar es coincidente con la tinta de la pluma incremento la cantidad hasta cien

    public static bool operator +(Pluma pluma,Tinta tinta)
    {
      if (pluma == tinta)
      {
        pluma._cantidad++;
        if (pluma._cantidad<=100)
        {
          return true;

        }else
        {
          return false;
        }
       }
      return false;
    }

    //operador -. Descontar tinta. Chequear que las tintas sean iguales .Decremento en 5.
    //Minimo sera 0
    public static bool operator -(Pluma pluma, Tinta tinta)
    {
      if (pluma == tinta )
      {
        pluma._cantidad-=10;
        if (pluma._cantidad <0)
        {
          pluma._cantidad =0;
          return true;

        }
        else
        {
          return false;
        }
      }
      return false;
    }



  }
}
