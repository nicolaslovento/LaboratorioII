using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesMascotas
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;

        public int Edad {

            get
            {
                return this._edad;

            }

            set
            {
                this._edad = value;

            }


        }

        public bool EsAlfa
        {

            get
            {
                return this._esAlfa ;

            }

            set
            {
                this._esAlfa = value;

            }


        }


        public Perro(string nombre, string raza,int edad,bool esAlfa):base(nombre, raza)
        {
            this._edad = edad;
            this._esAlfa = esAlfa;
        }

        public Perro(string nombre, string raza) :this(nombre,raza,0,false)
        {

        }

        protected override string Ficha()
        {
            if (this.EsAlfa == true)
            {
                return base.DatosCompletos() + " alfa de la manada, edad " + this._edad;
            }

            return base.DatosCompletos() + " edad " + this.Edad;
            
        }

        public static bool operator ==(Perro p1,Perro p2)
        {
            if(p1.Nombre==p2.Nombre && p1.Raza==p1.Raza && p1.Edad == p2.Edad)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            

            return !(p1==p2);
        }

        public static explicit operator int(Perro p)
        {
            return p.Edad;
        }

        public override string ToString()
        {
            return Ficha();
        }

        public override bool Equals(object obj)
        {
            return (obj==this);
        }

    }
}
