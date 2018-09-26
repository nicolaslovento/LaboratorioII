using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevasEntidades
{
  public class PaletaC
  {
    #region Atributos

    private List<tempera> _colores;
    private int _cantMaximaElementos;

    #endregion


    #region Constructor

    private PaletaC() : this(5)
    {


    }

    private PaletaC(int cant)
    {
      this._cantMaximaElementos = cant;
      this._colores = new List<tempera>();
    }

    #endregion



    #region Metodos

    private string Mostrar()
    {
      string datos = "Cantidad de Temperas para guardar: " + this._cantMaximaElementos;
      foreach (tempera t in this._colores)
      {
        if (!Object.Equals(t, null))
        {
          datos = datos + Environment.NewLine + t;
        }

      }

      return datos;
    }

    public static implicit operator string(PaletaC p)
    {
      return p.Mostrar();
    }

    public static explicit operator PaletaC(int cant)
    {
      PaletaC newPaleta = new PaletaC(cant);

      return newPaleta;
    }



    public static bool operator ==(PaletaC paleta, tempera tempera)
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
          
            if (t == tempera)
            {
              return true;
            }
          

        }
      }
      return false;
    }




    public static bool operator !=(PaletaC paleta, tempera tempera)
    {

      return !(paleta == tempera);
    }

    public static PaletaC operator +(PaletaC paleta, tempera temp)
    {

      int indice = -1;
      if (paleta == temp)
      {
        indice = paleta._colores.IndexOf(temp);
        paleta._colores[indice] += temp;
        //Sumo dos objetos de tipo tempera ya uardados en el array paleta
      }
      else
      {
        if(paleta._colores.Count< paleta._cantMaximaElementos)
        {
          paleta._colores.Add(temp);
        }
        
        
      }

      return paleta;

    }

    


    



    #endregion


  }
}
