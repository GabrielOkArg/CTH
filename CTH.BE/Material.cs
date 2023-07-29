using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Material
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public int cantidad { get; set; }

        public string MaterialCantidad
        {
            get{
                return "Nombre: "+nombre + " unidades: " + cantidad;
            }
        }

    }
}
