using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "s dfsd sdf aasdas asd aa asjd   bhasmdf ";
            string[] palabras = new string[400];

            string aux;
            int i = 0;
            while (s.Length > 0)
            {
                aux = s.Substring(0, s.IndexOf(" "));
                if (aux!="")
                {
                    palabras[i] = aux;
                    i++;
                }
                s=s.Remove(0,aux.Length+1);
                
            }
            int j;
            for(j=0; j < i; j++)
            {
                Console.WriteLine(palabras[j]);
            }

            Console.Read();

        }
    }
}
