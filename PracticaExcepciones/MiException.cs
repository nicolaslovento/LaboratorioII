using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExcepciones
{
    public class MiException:Exception
    {
        public MiException(string m):base(m)
        {

        }

        

        public MiException(string m,Exception inException) : base(m,inException)
        {

        }



    }
}
