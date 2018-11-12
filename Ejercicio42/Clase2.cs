using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Clase2
    {
        public Clase2()
        {
            try
            {
                Clase1.MetodoEstatico();//lanza exeception DividePorZero
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException(); 
            }
        }

    }
}
