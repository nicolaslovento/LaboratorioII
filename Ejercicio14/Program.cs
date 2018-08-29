using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    { /*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
        static void Main(string[] args)
        {
            int opcion;
            char seguir='s';
            double lado, radio, base1, altura;
            while(seguir=='s')
            { 
            Console.Write("1.Calcular area cuadrado.\n2.Calcular area Triangulo.\n3.Calcular area circulo.\nIngrese Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese lado: ");
                    lado = double.Parse(Console.ReadLine());
                    Console.Write("{0}", CalculoDeArea.CalcularCuadrado(lado));
                    break;
                case 2:
                    Console.Write("Ingrese Base: ");
                    base1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese Altura: ");
                    altura = double.Parse(Console.ReadLine());
                    Console.Write("{0}", CalculoDeArea.CalcularTriangulo(base1, altura));

                    break;
                case 3:
                    Console.Write("Ingrese Radio: ");
                    radio = double.Parse(Console.ReadLine());
                    Console.Write("{0}", CalculoDeArea.CalcularCirculo(radio));
                    break;
                default:
                        seguir = 'n';
                    break;

            }
                Console.ReadKey();
                Console.Clear();
            }
            Console.ReadKey();
            }

        }
    }

