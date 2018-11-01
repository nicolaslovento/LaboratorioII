using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{//Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene un Array de la clase Producto.
 //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
 //del depósito (REUTILIZAR CODIGO). 
 //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
 //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
 //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
 //se debe sumar el stock y no agregar dos veces al mismo producto.
 //Mostrar el contenido del array resultante (nombre y stock)
  public class Deposito
  {
      public Producto[] productos;

    public Deposito()
    {
      this.productos= new Producto[3];
    }

    public Deposito(int cantidad):this()
    {
      this.productos = new Producto[cantidad];
    }

    public static Producto[] operator +(Deposito d1,Deposito d2)
    {
      Producto[] nuevaLista=new Producto[d1.productos.Length+d2.productos.Length];
      int indice=0;
      
       for(int i=0;i<d1.productos.Length-1; i++)
       {
            for(int j=1; j < d1.productos.Length; j++)
            {
                if(d1.productos[i].nombre== d1.productos[j].nombre)
                {
                  d1.productos[j].stock +=  d1.productos[i].stock;
                  d1.productos[i] = null;
                }
            }
       }

            String s = "";
            foreach (Producto item in d1.productos)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }

            Console.WriteLine(s);
            for (int i = 0; i < d2.productos.Length ; i++)
            {
                for (int j = 1; j < d2.productos.Length; j++)
                {
                    if (d2.productos[i].nombre == d2.productos[j].nombre)
                    {
                        d2.productos[i].stock += d2.productos[j].stock;
                        d2.productos[j] = null;
                    }
                }
            }
            s = "";
            foreach (Producto item in d2.productos)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }

            Console.WriteLine(s);

            for (int i = 0; i < d1.productos.Length ; i++)
            {
                for (int j = 0; j < d2.productos.Length; j++)
                {
                    if (d1.productos[i].nombre == d2.productos[j].nombre)
                    {
                        d1.productos[i].stock += d2.productos[j].stock;
                        nuevaLista[indice] = d1.productos[i];
                        indice++;
                    }
                }
            }
            s = "";
            foreach (Producto item in nuevaLista)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }

            Console.WriteLine(s);


            return nuevaLista;

    }

    



  }
}
