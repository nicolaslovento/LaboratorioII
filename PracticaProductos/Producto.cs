using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
  //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
  //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
  //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
  //se debe sumar el stock y no agregar dos veces al mismo producto.
  //Mostrar el contenido del array resultante (nombre y stock)
  public class Producto
  {
      public  string nombre;
      public  int stock;

      public Producto(string nombre,int stock)
      {
      this.nombre = nombre;
      this.stock = stock;

      }
  }
}
