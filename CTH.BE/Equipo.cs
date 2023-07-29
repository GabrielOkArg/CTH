using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public   class Equipo
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string serial { get; set; }
        public DateTime alta { get; set; }
        public DateTime baja { get; set; }
        public bool activo { get; set; }
        public int id_sector { get; set; }

    }
}
