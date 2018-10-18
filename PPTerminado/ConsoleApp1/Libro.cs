using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas {

            get
            {
                if (this._cantidadDePaginas == 0)
                {
                    
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                    return this._cantidadDePaginas;
                }
                else
                {
                    return this._cantidadDePaginas;
                }
            }

        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(string titulo,Autor autor,float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
            
        }

        public Libro(float precio,string titulo,string nombre,string apellido)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = new Autor(nombre, apellido);
            

        }

        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();

            

            sb.AppendLine("*************************************");
            sb.AppendLine("Titulo " + l._titulo);
            sb.AppendLine("Precio " + l._precio);
            sb.AppendLine("Autor "+(string) l._autor);
            
            sb.AppendLine("Cantidad de pag " + l.CantidadDePaginas);

            return sb.ToString();
        }

        public static bool operator ==(Libro l1,Libro l2)
        {
            if(l1._titulo==l2._titulo && l1._autor == l2._autor)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static  explicit operator string(Libro l1)
        {
            return Libro.Mostrar(l1);
        }






    }
}
