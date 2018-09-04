using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEstante
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("PEP123"," Pepsi", ((float)30.50));
            Producto p2 = new Producto("PEP123", " Pepsi", ((float)30.50));
            Producto p3 = new Producto("SPR654", " Sprite", ((float)30.50));

            Console.WriteLine(p1.MostrarProducto(p1));
            Console.WriteLine(Producto.operatorIgualdad( p1,p2));
            Console.ReadKey();

        }
    }
}
