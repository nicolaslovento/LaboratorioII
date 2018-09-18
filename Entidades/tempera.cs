using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class tempera
    {
    #region Atributos
    private sbyte _cantidad;
    private ConsoleColor _color;
    private string _marca;
    #endregion

    #region Constructor
    public tempera(sbyte cant,ConsoleColor color,string marca)
    {
      this._cantidad = cant;
      this._color = color;
      this._marca = marca;

    }
    #endregion

    #region Metodos
    private string Mostrar()
    {
      return this._marca + " " + this._color + " " + this._marca;
    }

    public static implicit operator string(tempera temp)
    {
      return temp.Mostrar();
    }

    public static explicit operator sbyte(tempera temp)
    {
      return temp._cantidad;
    }

    public static bool operator ==(tempera temp1, tempera temp2)
    {
      if(temp1._color.Equals(temp2._color) && temp1._marca.Equals(temp2._marca))
      {
        return true;
      }

       return false;
    }

    public static bool operator !=(tempera temp1, tempera temp2)
    {
      return !(temp1 == temp2);
    }

    public static tempera operator +(tempera temp,sbyte cant)
    {
      
      if(temp!=null && cant>0)
      {
        tempera newTemp = new tempera((sbyte)(temp._cantidad + cant), temp._color, temp._marca);
        return newTemp;
      }

      return null;
}

    public static tempera operator +(tempera temp1, tempera temp2)
    {
      if (temp1==temp2)
      {
        tempera newTemp = new tempera((sbyte)(temp1._cantidad + temp2._cantidad), temp1._color, temp1._marca);
        return newTemp;
      }
      return null;

    }

    

    

    #endregion


  }
}
