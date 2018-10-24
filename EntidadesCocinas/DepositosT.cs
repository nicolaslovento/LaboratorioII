using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesCocinas
{
  public class Depositos<T>
  {
    private int _capacidadMaxima;
    private List<T> _lista;

    public Depositos(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      
      this._lista = new List<T>();
    }


    private int GetIndice(T a)
    {
      int indice = 0;
      foreach (T b in _lista)
      {

        if (b.Equals(a))
        {
          return indice;
        }
        indice++;
      }
      return -1;
    }

    public static bool operator +(Depositos<T> depo, T a)
    {

      bool retorno = false;
      if (depo._capacidadMaxima > depo._lista.Count)
      {
        depo._lista.Add(a);
        retorno = true;
      }

      return retorno;

    }

    public static bool operator -(Depositos<T> depo, T a)
    {

      int indice = depo.GetIndice(a);
      bool retorno = false;

      if (indice >= 0)
      {
        depo._lista.RemoveAt(indice);
        retorno = true;
      }

      return retorno;

    }

    public bool Agregar(T a)
    {
      if (this + a)
      {
        return true;
      }

      return false;
    }

    public bool Remover(T a)
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
      sb.AppendLine("Cantidad maxima: " + this._capacidadMaxima);
      sb.AppendLine("Listado de Cocinas: ");
      foreach (T c in this._lista)
      {
        sb.AppendLine(c.ToString());
      }

      return sb.ToString();
    }

  }

}
