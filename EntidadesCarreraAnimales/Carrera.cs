using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCarreraAnimales
{
    public class Carrera
    {
        public List<Animal> _animales;
        protected int _corredoresMax;

        

        private Carrera(int num,int n)
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredores):this(3,2)
        {
            this._corredoresMax = corredores;
        }
        public Carrera()
        {

        }

        public static Carrera operator +(Carrera c,Animal a)
        {
            if (c._corredoresMax > c._animales.Count)
            {
                foreach(Animal an in c._animales)
                {
                    if(an is Perro)
                    {
                        if ((Perro)an == a)
                        {
                            return c;
                        }
                    }

                    if (an is Caballo)
                    {
                        if ((Caballo)an == a)
                        {
                            return c;
                        }
                    }

                    if (an is Humano)
                    {
                        if ((Humano)an == a)
                        {
                            return c;
                        }
                    }
                }

                c._animales.Add(a);
            }

            return c;
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            foreach (Animal an in c._animales)
                {
                    if (an is Perro)
                    {
                        if ((Perro)an == a)
                        {
                            return true;
                        }
                    }

                    if (an is Caballo)
                    {
                        if ((Caballo)an == a)
                        {
                            return true;
                        }
                    }

                    if (an is Humano)
                    {
                        if ((Humano)an == a)
                        {
                            return true;
                        }
                    }
                }

             return false;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            
            return !(c==a);
        }

        public string MostrarCarrera(Carrera c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero de corredores: " + this._corredoresMax);
            foreach (Animal a in c._animales)
            {
                if (a is Perro)
                {

                    sb.AppendLine(((Perro)a).MostrarPerro());
                }

                if (a is Caballo)
                {
                    sb.AppendLine(((Caballo)a).MostrarCaballo());
                }

                if (a is Humano)
                {
                    sb.AppendLine(((Humano)a).MostrarHumano());
                }
            }

            return sb.ToString();
        }




    }
}
