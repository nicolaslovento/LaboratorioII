using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesClase7
{
  public class Paleta
  {
    #region Atributos

    private tempera[] _colores;
    private int _cantMaximaElementos;

    #endregion


    #region Constructor

    private Paleta() : this(5)
    {


    }

    private Paleta(int cant)
    {
      this._cantMaximaElementos = cant;
      this._colores = new tempera[this._cantMaximaElementos];
    }

    #endregion



    #region Metodos

    private string Mostrar()
    {
      string datos = "";
      foreach (tempera t in this._colores)
      {
        datos = datos + " " + t + "\n";
      }

      return this._cantMaximaElementos + " \n " + datos;
    }

    public static implicit operator string(Paleta p)
    {
      return p.Mostrar();
    }

    public static explicit operator Paleta(int cant)
    {
      Paleta newPaleta = new Paleta(cant);

      return newPaleta;
    }

    public static bool operator ==(Paleta paleta, tempera tempera)
    {
      /*
      for(int i=0;i<this._cantidadMaxima;i++){
      if(this._colores.getValue(i)!=null)//devuelve el object

      if(this._colores[i]==t)

      }
       */

      if (!Object.Equals(tempera, null))
      {
        foreach (tempera t in paleta._colores)
        {
          if (!Object.Equals(t, null))
          {
            if (t == tempera)
            {
              return true;
            }
          }

        }
      }
      return false;
    }

    


    public static bool operator !=(Paleta paleta, tempera tempera)
    {

      return !(paleta == tempera);
    }


    public static Paleta operator +(Paleta paleta, tempera temp){

      int indice = -1;
      if (paleta == temp)
      {
        indice = paleta.ObtenerIndice(temp);
        paleta._colores[indice] += temp;
        //Sumo dos objetos de tipo tempera ya uardados en el array paleta
      }
      else
      {
        indice = paleta.ObtenerIndice();//guardo temp en array de paleta
        if(indice>-1)
        {
          paleta._colores[indice] = temp;
        }
      }

      return paleta;

      }

    public static Paleta operator -(Paleta paleta, tempera temp)
    {
      int indice = -1;
      int cantidad;
      if (paleta == temp)
      {
        indice = paleta.ObtenerIndice(temp);
        cantidad=(sbyte)paleta._colores.GetValue(indice) - (sbyte)temp;//resto cantidades
        
        if (cantidad <= 0)
        {
          paleta._colores[indice]= null;
        }
        else
        {//si cantidad>0 guardo en la paleta con la nueva cantidad
          paleta._colores.SetValue((sbyte)paleta._colores.GetValue(indice) - (sbyte)temp, indice);
        }
      }

      
      
       return paleta;

    }

    /// <summary>
    /// Devuelve primer lugar libre de array Paleta.
    /// </summary>
    /// <returns></returns>
    private int ObtenerIndice()
    {

      for(int i=0;i<this._cantMaximaElementos ;i++)
      {
        if(this._colores.GetValue(i)==null)
        {
          return i;
        }
      }

      return -1;
    }

    /// <summary>
    /// dev
    /// </summary>
    /// <param name="temp"></param>
    /// <returns></returns>
    private int ObtenerIndice(tempera temp)
    {

      for (int i = 0; i < this._cantMaximaElementos; i++)
      {
        if ((tempera)this._colores.GetValue(i) == temp)
        {
          return i;
        }
      }

      return -1;

    }

      #endregion


    }
}
