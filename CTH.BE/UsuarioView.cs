using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class UsuarioView : Usuario
    {
        public UsuarioView()
        {
            _permisos = new List<Componente>();
        }

        List<Componente> _permisos;
        public int Id { get; set; }
        public string username { get; set; }

        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public override string ToString()
        {
            return username;
        }

    }
}
