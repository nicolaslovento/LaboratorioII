using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private byte _notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;
        Random rnd = new Random();
        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if (this._nota1 < 4 || this._nota2 < 4)
            {
                this._notaFinal = 1;
            }else
            {
                this._notaFinal =(byte)rnd.Next(1,10);
            }
        }

        public void Mostrar()
        {
            Console.Write("Nombre: {0}\nApellido: {1}\nLegajo: {2}\nNota 1: {3}\nNota 2: {4}\nNota Final: {5}\n\n", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2, this._notaFinal);
        }
    }
}
