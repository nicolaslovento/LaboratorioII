using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPPClase
{
  public enum EMarcas { Honda,Ford,Zanella,Scania,Iveco,Fiat}

  public  class Vehiculo
  {
    protected string _patente;
    protected Byte _cantRuedas;
    protected EMarcas _marca;

    public string Patente { get{ return this._patente; } }
    public EMarcas Marca { get { return this._marca; } }
    public Byte Ruedas { get { return this._cantRuedas; } set { this._cantRuedas = value; } }

    

    public Vehiculo(string patente,Byte ruedas,EMarcas marca)
    {
      this._cantRuedas = ruedas;
      this._patente = patente;
      this._marca = marca;
    }

    protected virtual string Mostrar()
    {
      string info;
      info = "Marca: " + this._marca + " Ruedas: " + this._cantRuedas + " Patente: " + this._patente;
      return info;
    }

    public virtual string ToString()
    {
      return Mostrar();
    }

    public static bool operator ==(Vehiculo v1,Vehiculo v2)
    {
      if(v1._patente.Equals(v2._patente) && v1._marca.Equals(v2._marca))
      {
        return true;
      }
      return false;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
      return !(v1 == v2);
    }
  }
}
