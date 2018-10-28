using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    /*Tomar el ejercicio anterior. Sobreescrito será una clase abstracta.
a. Agregar un atributo miAtributo del tipo string, con visibilidad protected.
b. Generar un constructor de instancia que inicialice miAtributo con "Probar abstractos".
c. Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada,
retornará el valor de miAtributo.
d. Crear un método abstracto MiMetodo que retorne un string. Una vez implementada,
retornará el valor de MiPropiedad.
e. Agregar una clase llamada SobreSobreescrito que herede de Sobreescrito. Implementar el
código necesario para que todo funcione correctamente.
f. Modificar el Main para probar las modificaciones.*/
    class Program
    {
        static void Main(string[] args)
        {
            SobreSobreescrito sb = new SobreSobreescrito();

            Console.WriteLine(sb.MiMetodo());
            Console.WriteLine(sb.MiPropiedad);

            Console.ReadLine();


        }
    }
}
