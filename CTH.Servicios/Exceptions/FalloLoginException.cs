using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.Servicios.Exceptions
{
    public  class FalloLoginException : Exception
    {



        public FalloLoginException(string mensaje) : base(mensaje)
        {
            
        }
    }
}
