using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSello
{
    class Sello
    {

    public static string mensaje="Hola";
    

    public static void imprimir()
    {
      armarFormato(mensaje);
    }

    public static void borrar()
    {
      mensaje = "";
    }

    public static void imprimirEnColor()
    {
      Console.BackgroundColor = ConsoleColor.Green;
      Console.Write(mensaje);
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







  }
}
