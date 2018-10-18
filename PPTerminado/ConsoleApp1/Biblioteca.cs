using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum ELibro { Manual,Novela,Ambos}
    class Biblioteca
    {
        private int _cap;
        private List<Libro> _libros;

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int cap):this()
        {
            this._cap = cap;
        }

        public static string Mostrar(Biblioteca b)
        {
            Console.WriteLine("Precio de Manuales {0:.##}", b.PrecioManuales);
            Console.WriteLine("Precio de Novelas {0:.##}", b.PrecioNovelas);
            Console.WriteLine("Precio Total {0:.##}", b.PrecioTotal);
            StringBuilder sb = new StringBuilder();
            foreach (Libro l in b._libros)
            {
                if(l is Manual)
                {
                    Manual m = (Manual)l;

                    sb.AppendLine(m.Mostrar());
                }

                if (l is Novela)
                {
                    Novela n = (Novela)l;

                    sb.AppendLine(n.Mostrar());
                }


            }

            return sb.ToString();
        }

        public static implicit operator Biblioteca(int cap)
        {
            Biblioteca b = new Biblioteca(cap);

            return b;
        }

        public static bool operator ==(Biblioteca b,Libro l)
        {
            if(l is Manual)
            {
                Manual l3 = (Manual)l;
                foreach (Libro l2 in b._libros)
                {
                    if (l2 is Manual)
                    {
                        Manual m = (Manual)l2;

                        if (m == l3)
                        {
                            return true;
                        }
                        
                    }
                }
            }

            if (l is Novela)
            {
                Novela l3 = (Novela)l;
                foreach (Libro l2 in b._libros)
                {
                    if (l2 is Novela)
                    {
                        Novela m = (Novela)l2;

                        if (m == l3)
                        {
                            return true;
                        }

                    }
                }
            }



            return false;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b,Libro l)
        {
            if (b._libros.Count < b._cap)
            {
                if((b == l)==true)
                {
                    Console.WriteLine("El libro ya esta en la biblioteca");
                }
                else
                {
                    b._libros.Add(l);
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la biblioteca");
            }

            return b;
        }

        private double ObtenerPrecio(ELibro tipo)
        {
            double cant_Manual=0;
            double cant_Novela = 0;
            double retorno=0;
            
            foreach (Libro l in this._libros)
            {
                if(l is Manual)
                {
                    Manual m = (Manual)l;
                    cant_Manual+=(double)m;
                }

                if (l is Novela)
                {
                    Novela n = (Novela)l;
                    cant_Novela += (double)n;
                }
            }

            switch (tipo)
            {
                case ELibro.Manual:
                    retorno = cant_Manual;
                    break;
                case ELibro.Novela:
                    retorno = cant_Novela;
                    break;
                case ELibro.Ambos:
                    retorno = cant_Novela + cant_Manual;
                    break;


            }

            return retorno;
        }

        public double PrecioManuales {
            get
            {
                return ObtenerPrecio(ELibro.Manual);
            }
        }
        public double PrecioNovelas
        {
            get
            {
                return ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(ELibro.Ambos);
            }
        }




    }
}
