using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CTH.BE
{
    public class Solicitud
    {

        public int id { get; set; }
        public int id_edificio { get; set; }
        public int id_sector { get; set; }
        public int id_equipo { get; set; }
        public int id_creador { get; set; }
        public string edificio { get; set; }
        public string sector { get; set; }
        public string equipo { get; set; }
        public string detalle { get; set; }
        public Usuario creador { get; set; }
        public string userName { get; set; }
        public string estado { get; set; }
        public DateTime Creado { get; set; }
    }
}
