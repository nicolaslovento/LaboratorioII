using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarreraAnimales
{
    public abstract class Animal
    {
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
        protected int _velocidadMaxima;

        public int CantidadPatas {

            get
            {
                if (this._cantidadPatas > 4 || this._cantidadPatas<0)
                {
                    this._cantidadPatas = 4;
                }

                return this._cantidadPatas;

            }
            set
            {
                if (value > 4 || value < 0)
                {
                    this._cantidadPatas = 4;
                }
                else
                {
                    this._cantidadPatas = value;
                }
            }
        }

        public int DistanciaRecorrida { get
            {
               
                return Animal._distanciaRecorrida.Next(10, this._velocidadMaxima);
            }  }

        public int VelocidadMaxima {
            get
            {
                if (this._velocidadMaxima > 60 || this._velocidadMaxima < 0)
                {
                    this._velocidadMaxima = 60;
                }

                return this._velocidadMaxima;

            }
            set
            {
                if (value > 60 || value < 0)
                {
                    this._velocidadMaxima = 60;
                }
                else
                {
                    this._velocidadMaxima = value;
                }
            }


        }


        static Animal()
        {
            Animal._distanciaRecorrida = new Random();
        }

        
        public Animal(int CantidadPatas,int velocidadMaxima)
        {
            this.CantidadPatas = CantidadPatas;
            this.VelocidadMaxima=velocidadMaxima;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de Patas: " + this._cantidadPatas);
            sb.AppendLine("Velocidad Maxima: " + this._velocidadMaxima);
            sb.Append("Distancia recorria: " + this.DistanciaRecorrida);

            return sb.ToString();
        }

    }
}
