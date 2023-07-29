using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.DAL.Mappers;
using CTH.BE;
using CTH.Servicios;

namespace CTH.BLL
{
    public class IdiomaLogic
    {




        public List<Idioma> getIdiomas()
        {
            MapperIdioma mapperIdioma = new MapperIdioma();
            return mapperIdioma.GetAll();
        }
    }
}
