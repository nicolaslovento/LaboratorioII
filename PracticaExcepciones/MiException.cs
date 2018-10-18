using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExcepciones
{
    class MiException:Exception
    {
        public MiException():base("Error")
        {

        }

        

        public MiException(string m,Exception inException) : base(m,inException)
        {

        }



    }
}
