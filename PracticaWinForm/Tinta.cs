using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
  class Tinta
  {
    private ConsoleColor color;
    private EtipoTinta tipo;

    #region CONSTRUCTOR Y SOBRECARGAS

    public Tinta()
    {
      this.color = ConsoleColor.Blue;
      this.tipo = EtipoTinta.ConBrillo;
    }

    public Tinta(EtipoTinta tipo) : this()
    {
      this.tipo = tipo;
    }

    public Tinta(ConsoleColor color) : this()
    {
      this.color = color;
    }

    public Tinta(ConsoleColor color, EtipoTinta tipo)
    {
      this.color = color;
      this.tipo = tipo;
    }

    #endregion

    public static string MostrarEst(Tinta obj)
    {
      if (!object.Equals(obj, null))
      {
        return obj.MostrarPriv();
      }
      return "--";
    }

    private string MostrarPriv()
    {
      return this.color + "  " + this.tipo;
    }

    //Sobrecarga de operadores

    public static bool operator == (Tinta t1, Tinta t2)
    {
       if(!object.Equals(t1,null) && !object.Equals(t1, null))
      {
        if(t1.color==t2.color && t1.tipo==t2.tipo)
         {
            return true;
        }else
        {
          return false;
        }
      }
      return false;
    }

    public static bool operator !=(Tinta t1, Tinta t2)
    {
      return !(t1 == t2);
    }



  }
}
