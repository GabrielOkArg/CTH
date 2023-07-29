using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;

namespace CTH.Servicios
{
    public class IdiomaManager
    {
        public static object _lock = new object();
        public static IdiomaManager _idioma;

        public Idioma Idioma { get; set; }

        public static IdiomaManager getIdioma
        {
            get
            {
                try
                {
                    return _idioma;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public static void loadIdioma(Idioma idioma)
        {
            lock (_lock)
            {
                if (_idioma == null)
                {
                    _idioma = new IdiomaManager();
                    _idioma.Idioma = idioma;
                }
            }
        }


        public static void ClearIdioma()
        {
            lock (_lock)
            {
                if (_idioma != null)
                {
                    _idioma = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }


        }
    }
}
