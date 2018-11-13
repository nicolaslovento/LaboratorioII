using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSP
{
    public class Auto : Vehiculo
    {
        

        public int puertas;

        public Auto():base("",2,ConsoleColor.Black)
        {
            
        }
        
        public Auto(string marca, int cantRuedas, ConsoleColor color,int puertas) : base(marca, cantRuedas, color)
        {
            this.puertas = puertas;
            
        }

        public override string Mostrar()
        {
            return base.Mostrar() + "Puertas: " + this.puertas+"\n\n";
        }
    }
}
