using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Usuario
    {

        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        public Usuario(string _username)
        {
            username = _username;
            _permisos = new List<Componente>();
        }

        private string username;
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id { get; set; }
        public string pass { get; set; }
        public bool bloqueo { get; set; }
        public string intentos { get; set; }
        public string getFullName { get { return nombre + " " + apellido; } }
        public string getUserName { get { return username; } }
        List<Componente> _permisos;
        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }
    }
}
