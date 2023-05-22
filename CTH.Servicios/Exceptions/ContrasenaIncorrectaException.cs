using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.Servicios.Exceptions
{
    public  class ContrasenaIncorrectaException : Exception
    {

        public ContrasenaIncorrectaException() : base("La contraseña ingresada es incorrecta")
        {

        }
    }
}
