using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    /*
     a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)*/
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularCirculo(double radio)
        {
            double pi = 3.14;
            double resultado=pi*radio*radio;

            return resultado;
        }
        public static double CalcularTriangulo(double base1,double altura)
        {
            double resultado=(base1*altura)/2;

            return resultado;
        }
    }
}
