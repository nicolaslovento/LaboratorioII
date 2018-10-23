using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase16
{
  public class Auto
  {
    private string _color;
    private string _marca;

    public string Color {
      get
      {
        return this._color;
      }

    }

    public string Marca
    {
      get
      {
        return this._marca;
      }

    }


    public Auto(string color,string marca)
    {
      this._marca = marca;
      this._color = color;
    }

    public static bool operator ==(Auto a,Auto b)
    {
      if(a._color==b._color && a._marca == b._marca)
      {
        return true;
      }

      return false;
    }

    public static bool operator !=(Auto a, Auto b)
    {
      return !(a == b);
    }


    public override bool Equals(object obj)
    {
      if(obj is Auto )//falta
      {
        Auto b=(Auto)obj;

        if (b==(this))
        {
          return true;
        }
        
      }

      return false;
    }

    public virtual string ToString()
    {
      return string.Format("Marca: " + this._marca + " Color: " + this._color);
    }


  }
}
