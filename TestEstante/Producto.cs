using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEstante
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigo,string marca,float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        //Igualdad (Producto, Producto). Retornará true, si las marcas y códigos de barras son iguales, false, caso contrario.
        public static bool operatorIgualdad(Producto prod1,Producto prod2)
        {
            if(prod1.marca.Equals(prod2.marca) && prod1.codigoDeBarra.Equals(prod2.codigoDeBarra))
            {
                return true;
            }
            return false;
        }
        //Igualdad (Producto, string). Retornará true, si la marca del producto coincide con la cadena pasada por parámetro, false,
        //caso contrario.
        public bool operatorIgualdad(Producto prod,string marca)
        {
            if (prod.marca.Equals(marca))
            {
                return true;
            }
            return false;
        }


        public string MostrarProducto(Producto miProducto)
        {
            return miProducto.marca + " " + miProducto.precio + " " + miProducto.codigoDeBarra;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        //devuelve codigo de barra del producto q recibe como parametro
        public string OperatorString(Producto miProducto)
        {
            return miProducto.codigoDeBarra;
        }

        public string GetCodigo()
        {
            return this.codigoDeBarra;
        }
    }
}
