using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSP
{
    public abstract class Vehiculo
    {
        public string marca;
        public int cantRuedas;
        public ConsoleColor color;

        protected Vehiculo(string marca, int cantRuedas, ConsoleColor color)
        {
            this.marca = marca;
            this.cantRuedas = cantRuedas;
            this.color = color;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Cantidad de Ruedas: "+ this.cantRuedas );
            sb.AppendLine("Color:" + this.color);
            return sb.ToString();
        }
    }
}
