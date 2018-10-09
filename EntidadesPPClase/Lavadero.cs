using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPPClase
{
  public enum EVehiculos { Auto, Camion, Moto };


  public class Lavadero
  {
    private List<Vehiculo> _vehiculos;
    private static float _precioAuto;
    private static float _precioCamion;
    private static float _precioMoto;
    private string _razonSocial;

    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    static Lavadero()
    {
      _precioAuto = 200;
      _precioCamion = 300;
      _precioMoto = 500;
    }

    public Lavadero(string razon) : this()
    {
      this._razonSocial = razon;
    }

    public string LavaderoToString { get { return ToString(); } }

    private string ToString()
    {

      string infoLav = string.Format("Razon Social: {0}\n Precios Vigentes:\nCamion: {1}\nAuto:{2}\nMoto:{3}", this._razonSocial, _precioCamion, _precioAuto, _precioMoto);
      string infoVehiculos = "";
      foreach (Vehiculo v in this._vehiculos)
      {
        infoVehiculos += v.ToString();
      }

      return infoLav + "\n" + infoVehiculos;

    }
    public string VehiculosToString { get { return ToStringVehiculos(); } }

    private string ToStringVehiculos()
    {


      string infoVehiculos = "";
      foreach (Vehiculo v in this._vehiculos)
      {
        infoVehiculos += v.ToString();
      }

      return infoVehiculos;
    }




    public double MostrarTotalFacturado()
    {
      double total = 0;
      foreach (Vehiculo v in this._vehiculos)
      {
        if (v is Camion)
        {
          total += _precioCamion;
        }
        else
        {
          if (v is Auto)
          {
            total += _precioAuto;
          }
          else
          {
            total += _precioMoto;
          }
        }
      }

      return total;
    }

    public double MostrarTotalFacturado(EVehiculos vElegido)
    {
      double total = 0;


      if (vElegido.Equals("Camion"))
      {
        foreach (Vehiculo v in this._vehiculos)
        {
          if (v is Camion)
          {
            total += _precioCamion;
          }
        }
      }
      else
      {
        if (vElegido.Equals("Auto"))
        {
          foreach (Vehiculo v in this._vehiculos)
          {
            if (v is Auto)
            {
              total += _precioAuto;
            }
          }
        }
        else
        {
          total += _precioMoto;
        }
      }
      return total;
    }

    public static bool operator ==(Lavadero lav, Vehiculo veh)
    {
      foreach (Vehiculo v in lav._vehiculos)
      {
        if (v == veh)
        {
          return true;
        }

      }

      return false;
    }

    public static bool operator !=(Lavadero lav, Vehiculo veh)
    {
      return !(lav == veh);
    }

    public static int operator ==(Vehiculo veh, Lavadero lav)
    {
      foreach (Vehiculo v in lav._vehiculos)
      {
        if (v == veh)
        {
          return lav._vehiculos.IndexOf(v);
        }

      }

      return -1;
    }

    public static int operator !=(Vehiculo veh, Lavadero lav)
    {
      return 0;
    }

   public static Lavadero operator +(Lavadero lav, Vehiculo veh)
    {
      if (lav != veh)
      {
        lav._vehiculos.Add(veh);
      }

      return lav;
    }

    public static Lavadero operator -(Lavadero lav, Vehiculo veh)
    {
      if (lav == veh)
      {
        lav._vehiculos.Remove(veh);
      }

      return lav;
    }

    public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
    {
      int num = string.Compare(v1.Patente, v2.Patente);

      return num;
    }

    public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
    {
      int num = string.Compare(v1.Marca.ToString(), v2.Marca.ToString());


      return num;

    }


  }
}
   
