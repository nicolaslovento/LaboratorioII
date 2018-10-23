using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesCocinas
{
  public class DepositoDeCocinas
  {
    private int _capacidadMaxima;
    private List<Cocina> _lista;

    public DepositoDeCocinas(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<Cocina>();
    }


    private int GetIndice(Cocina a)
    {
      int indice = 0;
      foreach (Cocina b in _lista)
      {

        if (b == a)
        {
          return indice;
        }

        indice++;
      }

      return -1;
    }

    public static bool operator +(DepositoDeCocinas depo, Cocina a)
    {

      bool retorno = false;
      if (depo._capacidadMaxima > depo._lista.Count)
      {
        depo._lista.Add(a);
        retorno = true;
      }

      return retorno;

    }

    public static bool operator -(DepositoDeCocinas depo, Cocina a)
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

    public bool Agregar(Cocina a)
    {
      if (this + a)
      {
        return true;
      }

      return false;
    }

    public bool Remover(Cocina a)
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
      foreach (Cocina c in this._lista)
      {
        sb.AppendLine(c.ToString());
      }

      return sb.ToString();
    }

    #region 
    public bool Guardar(string s)
    {
      StreamWriter sw;
      sw= new StreamWriter(s,false);//1parametro=ruta del archivo.//bool que indica si sobreescribo(false) o agrego(true)(default false)
      //si no existe el archivo lo crea.
      try
      {


        sw.WriteLine(this.ToString());
        sw.Close();//cierra el archivo
        return true;
      }
      catch (Exception e)
      {
        return false;
      }

      /*
      using(sw=new StreamWriter()){

      sw.WriteLine(this.ToString());
      //internamente invoca al metodo de cierre de archivo(no hace falta el close)
      }
       */
    }


    public bool Recuperar(string patch)
    {
      StreamReader sw;
      sw = new StreamReader(patch, false);
      try
      {


        Console.WriteLine(sw.ReadToEnd());
        sw.Close();
        return true;
      }
      catch (Exception e)
      {
        return false;
      }


    }

    #endregion

  }
}
