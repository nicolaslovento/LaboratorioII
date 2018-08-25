using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.*/
        static void Main(string[] args)
        {
            int numero;
            int maximo=0;
            int minimo=0,total=0;
            int i;
            double promedio;
            Boolean esNumero;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresar numero {0}: ", i);
                esNumero = int.TryParse(Console.ReadLine(), out numero);

                if (esNumero)
                {
                    if (i == 0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        else
                        {
                            if (numero > maximo)
                            {
                                maximo = numero;
                            }

                        }
                    }

                    total = total + numero;
                }

                
            }
            promedio = total / 5;
            Console.WriteLine("Valor maximo {0}, valor minimo {1}, promedio {2}", maximo,minimo,promedio);
            Console.ReadLine();
        }
    }
}
