using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEj16
{
  public class DepositoDeAutos
  {
    private int _capacidadMaxima;
    private List<Auto> _lista;

    public DepositoDeAutos(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<Auto>();
    }


    private int GetIndice(Auto a)
    {
      int indice = 0;
      foreach (Auto b in _lista)
      {

        if (b == a)
        {
          return indice;
        }

        indice++;
      }

      return -1;
    }

    public static bool operator +(DepositoDeAutos depo, Auto a)
    {

      bool retorno = false;
      if (depo._capacidadMaxima > depo._lista.Count)
      {
        depo._lista.Add(a);
        retorno = true;
      }

      return retorno;

    }

    public static bool operator -(DepositoDeAutos depo, Auto a)
    {

      int indice= depo.GetIndice(a);
      bool retorno = false;
      
        if (indice>=0)
        {
          depo._lista.RemoveAt(indice);
          retorno = true;
        }

       return retorno;

    }

    public bool Agregar(Auto a)
    {
      if (this + a)
      {
        return true;
      }

      return false;
    }

    public bool Remover(Auto a)
    {
      if (this - a)
      {
        return true;
      }

      return false;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Cantidad maxima: " +this._capacidadMaxima);
      sb.AppendLine("Listado de Autos: ");
      foreach(Auto a in this._lista)
      {
        sb.AppendLine(a.ToString());
      }

      return sb.ToString();
    }



  }
}
