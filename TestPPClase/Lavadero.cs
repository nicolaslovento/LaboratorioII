using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPPClase
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
            Random random = new Random();
      _precioAuto = random.Next(150,565);
      _precioCamion = random.Next(150, 565);
      _precioMoto = random.Next(150, 565);
    }

    public Lavadero(string razon) : this()
    {
      this._razonSocial = razon;
    }

    public List<Vehiculo> ListaVehiculos { get {return this._vehiculos; } }

    public string LavaderoToString {
            get
            {
                string infoLav = string.Format("Razon Social: {0}\nPrecios Vigentes:\nCamion: {1}\nAuto:{2}\nMoto:{3}\n\n", this._razonSocial, _precioCamion, _precioAuto, _precioMoto);
                string infoVehiculos = "";
                foreach (Vehiculo v in this._vehiculos)
                {
                    infoVehiculos += v.ToString()+"\n";
                }

                return infoLav + "\n" + infoVehiculos;
            } }

    
    public string VehiculosToString {
            get
            {

                string infoVehiculos = "";
                foreach (Vehiculo v in this._vehiculos)
                {
                    infoVehiculos += v.ToString()+"\n";
                }

                return infoVehiculos;
            } }

    public double MostrarTotalFacturado()
    {
      return MostrarTotalFacturado(EVehiculos.Auto)+ MostrarTotalFacturado(EVehiculos.Camion) + MostrarTotalFacturado(EVehiculos.Moto) ;
    }

    public double MostrarTotalFacturado(EVehiculos vElegido)
    {
        int cant_Auto = 0, cant_Moto = 0, cant_Camion = 0; 
        double total = 0;

      foreach(Vehiculo v in this._vehiculos)
      {
                if(v is Auto)
                {
                    cant_Auto++;
                }
                if (v is Camion)
                {
                    cant_Camion++;
                }
                if (v is Moto)
                {
                    cant_Moto++;
                }
      }
      
            switch (vElegido)
            {
                case EVehiculos.Auto:
                    total = cant_Auto * Lavadero._precioAuto;
                    break;
                case EVehiculos.Camion:
                    total = cant_Camion * Lavadero._precioCamion;
                    break;
                case EVehiculos.Moto:
                    total = cant_Moto * Lavadero._precioMoto;
                    break;
                default:
                    break;
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
      for(int i=0; i < lav._vehiculos.Count; i++)
            {
                if (veh == lav._vehiculos[i])
                {
                    return i;
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
            for (int i = 0; i < lav._vehiculos.Count; i++)
            {
                if (veh == lav._vehiculos[i])
                {
                    lav._vehiculos.RemoveAt(i);
                    break;
                }
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
   
