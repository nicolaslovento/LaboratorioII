using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        /*Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
posea la siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/
        static void Main(string[] args)
        {
            int num;
            bool esNum;
            double promedio;
            int max = 0, min = 0, acumulador = 0;
            bool flag = true;
            for (int i = 1; i < 11;i++)
            {
                Console.Write("Ingresar numero {0}: ", i);
                esNum = int.TryParse(Console.ReadLine(), out num);

                while(esNum == false || Validar.ValidarNumero(num,-100,100)==false)
                {
                        Console.Write("Reingresar numero {0} (debe ser un numero y debe ser entre -100 y 100): ", i);
                        esNum = int.TryParse(Console.ReadLine(), out num);
                }

                if(flag)
                {
                    min = num;
                    max = num;
                    flag = false;
                }else
                {
                    if(num<min)
                    {
                        min = num;
                    }

                    if(num>max)
                    {
                        max = num;
                    }
                }

                acumulador += num;


             }
            promedio =(double) acumulador / 10;
            Console.Write("Valor minimo: {0}\nValor maximo: {1}\nPromedio: {2}", min, max,promedio);
            Console.Read();

            }
        }
    }

