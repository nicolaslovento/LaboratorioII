using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfaces
{
    public class Vehiculo:ImpuestoNacional,ImpuestoProvincial
    {
        private double precio;

        public Vehiculo(double precio)
        {
            this.precio = precio;
        }


        public double AplicarImpuestoNacinal { get {return ((ImpuestoNacional)this).AplicarImpuesto(); }  }

        double ImpuestoNacional.AplicarImpuesto()
        {
            return this.precio*2;
        }

         double ImpuestoProvincial.AplicarImpuesto()
        {
            return this.precio*5;
        }
    }
}
