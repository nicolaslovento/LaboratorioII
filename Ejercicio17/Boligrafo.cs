using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligrafo
{
    class Boligrafo
    {
        const short cantidadTintaMaxima=100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo(ConsoleColor color,short tinta)
        {
            this._color = color;
            this._tinta = tinta;

        }

        public void Pintar(int gasto)
        {
            short tinta = this._tinta;

            tinta -=(short) gasto;

            if(tinta>=0 && tinta<=cantidadTintaMaxima)
            {
                this._tinta = tinta;
                Console.ForegroundColor=this._color;
                Console.WriteLine("Se ha pintado y su nivel de tinta es {0}", this._tinta);
                Console.ForegroundColor =ConsoleColor.Black;

            }else
            {
                Console.WriteLine("No se pudo pintar.Tinta insuficiente.");
            }
        }

        public void Recargar()
        {
            this._tinta = cantidadTintaMaxima;
        }

        private void setTinta(short tinta)
        {
            if(tinta>=0 && tinta <= cantidadTintaMaxima)
            {
                this._tinta +=  tinta;
            }
            else
            {
                Console.Write("No se pudo cargar/gastar tinta.");
            }
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

        public short getTinta()
        {
            return this._tinta;
        }

    }
}
