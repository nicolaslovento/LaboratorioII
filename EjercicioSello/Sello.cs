using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSello
{
    class Sello
    {

    public static string mensaje="a";
    

    public static void imprimir()
    {
      if(TryParse(mensaje,out mensaje))
      {

        armarFormato(mensaje);
      }
    }

    public static void borrar()
    {
      mensaje = "";
    }

    public static void imprimirSinColor()
    {
      armarFormato(mensaje);
    }

    public static void imprimirEnColor()
    {
      Console.BackgroundColor = ConsoleColor.Green;
      armarFormato(mensaje);
      Console.BackgroundColor = ConsoleColor.Black;
    }

    private static void armarFormato(string msj)
    {
      string a="**";

      for(int i=0; i<msj.Length;i++)
      {
        a += "*";
      }
      Console.WriteLine(a);
      Console.WriteLine("*{0}*", msj);
      Console.WriteLine(a);

    }

    private static bool TryParse(string msj, out string msjSalida)/*parametro de salida*/
    {
      if(msj.Length>0)
      {
        msjSalida = msj;
        return true;
      }
      msjSalida = "";
      return false;

    }





  }
}
