using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSP
{
    public class Camion : Vehiculo
    {
        public double toneladas;
        public Camion(string marca, int cantRuedas, ConsoleColor color,double toneladas) : base(marca, cantRuedas, color)
        {
            this.toneladas = toneladas;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "Toneladas: " + this.toneladas+"\n\n";
        }

    }
}
