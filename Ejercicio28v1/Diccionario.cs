using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio28v1
{
    public class Diccionario
    {
        private  static Dictionary<string, int> _palabras;

        static Diccionario()
        {
            _palabras = new Dictionary<string, int>();
        }


        public string GuardarEnLista(Diccionario d, string[] palabras)
        {
            int contador = 0;
            int flag = 0;
                for(int i=0;i< palabras.Length-1; i++)
                {
                    contador = 0;
                        for (int j = i+1; i < palabras.Length; i++)
                        {   
                            if (palabras[i]==palabras[j])
                            {
                                contador++;
                            }
                        }

                    foreach(KeyValuePair<string, int> entry in Diccionario._palabras)
                    {
                        if(entry.Key== palabras[i])
                        {
                            flag = 1;
                        }
                        
                     }

                if (flag != 1) { Diccionario._palabras.Add(palabras[i], contador);  }
                    

                }

            StringBuilder sb = new StringBuilder();

            
            foreach(KeyValuePair<string, int> entry in Diccionario._palabras)
            {
                sb.AppendLine(entry.Key +"  "+entry.Value);
            }


            return sb.ToString();

        }

        public string[] contarPalabras(string s)
        {
            string[] palabras = new string[100];

            string aux;
            int i = 0;
            while (s.Length > 0)
            {
                aux = s.Substring(0, s.IndexOf(" "));
                if (aux != "")
                {
                    palabras[i] = aux;
                    i++;
                }
                s = s.Remove(0, aux.Length + 1);

            }
            return palabras;
        }
    }
}
