using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPPClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero miLavadero = new Lavadero("Lavadero S.A");

            Auto a1 = new Auto("ACB123", EMarcas.Fiat, 4);
            Auto a2 = new Auto("WCZ423", EMarcas.Iveco, 3);
            Camion c1 = new Camion("JAS134", 6, EMarcas.Fiat, 130);
            Moto m1 = new Moto(EMarcas.Zanella, 200, "ASD234", 4);
            Vehiculo v1 = new Vehiculo("AAB111", 4, EMarcas.Ford);
            Camion c2 = new Camion(v1, 150);

            miLavadero += a1;
            miLavadero += a2;
            miLavadero -= a1;
            miLavadero += c1;
            miLavadero += m1;
            miLavadero += c2;
            

            Console.WriteLine("------------------------SIN ORDENAR-----------------------------");
            Console.WriteLine(miLavadero.LavaderoToString);

            Console.WriteLine("------------------------ORDENADO POR MARCA-----------------------------");
            miLavadero.ListaVehiculos.Sort(miLavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(miLavadero.VehiculosToString);

            Console.WriteLine("------------------------ORDENADO POR PATENTE-----------------------------");
            miLavadero.ListaVehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(miLavadero.VehiculosToString);

            Console.WriteLine("Total facturado por tipo:\nAuto: {0}\nCamion: {1}\nMoto: {2}\n", miLavadero.MostrarTotalFacturado(EVehiculos.Auto), miLavadero.MostrarTotalFacturado(EVehiculos.Camion), miLavadero.MostrarTotalFacturado(EVehiculos.Moto));
            Console.WriteLine("Total facturado: {0}", miLavadero.MostrarTotalFacturado());

            Console.Read();


        }
    }
}
