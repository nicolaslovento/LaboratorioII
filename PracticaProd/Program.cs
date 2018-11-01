using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProd
{
    class Producto
    {
        public string nombre;
        public int stock;

        public Producto(string n,int s)
        {
            this.nombre = n;
            this.stock = s;
        }
    }
    class Deposito
    {
        public Producto[] productos=new Producto[4];
    }
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            Deposito d1 = new Deposito();
            Deposito d2 = new Deposito();

            d1.productos[0] = p1;
            d1.productos[1] = p2;
            d1.productos[2] = p3;
            d1.productos[3] = p3;

            d2.productos[0] = p1;
            d2.productos[1] = p1;
            d2.productos[2] = p2;

            Producto[] nuevaLista = new Producto[d1.productos.Length + d2.productos.Length];
            int indice = 0;

            for (int i = 0; i < d1.productos.Length - 1; i++)
            {
                for (int j = 1; j < d1.productos.Length; j++)
                {
                    
                        if (!Object.Equals(d1.productos[i], null))
                        {
                            if (d1.productos[i].nombre == d1.productos[j].nombre)
                            {
                            
                            d1.productos[j].stock += d1.productos[i].stock;
                            d1.productos[i] = null;
                            }
                        }
                    
                }
            }
            String s = "";
            foreach (Producto item in d1.productos)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }

            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
