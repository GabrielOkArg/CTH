using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.BE
{
    public class Usuario
    {

        public Usuario(string _username)
        {
            username = _username;
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
    }
}
