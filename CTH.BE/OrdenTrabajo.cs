using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class OrdenTrabajo
    {

        public int id { get; set; }
        public int solicitud_id { get; set; }
        public int cordinadorId { get; set; }
        public string coordinador { get; set; }
        public int tecnicoId { get; set; }
        public string tecnico { get; set; }
        public string detalleCoordinador { get; set; }
        public string detalleTecnico { get; set; }
        public int horas { get; set; }
        public bool finalizada { get; set; }
        public bool cerrada { get; set; }
        public DateTime fechacreacion { get; set; }
        public DateTime fechacierre { get; set; }
        public DateTime fechafinalizacion { get; set; }
        public Solicitud solicitud { get; set; }
    }
}
