using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.Servicios.Enum;

namespace CTH.Servicios
{
    public  class Bitacora
    {
        public Bitacora(DateTime dateTime)
        {
            this.fecha = dateTime;
        }
        public Bitacora()
        {
            this.fecha = DateTime.Now;
        }

        private DateTime fecha;
        public DateTime fechaBitacora() { return fecha; }
        public MotivoBitacora motivo { get; set; }
        public string userName { get; set; }

    }
}
