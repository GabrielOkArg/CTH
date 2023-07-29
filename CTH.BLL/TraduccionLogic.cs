using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL.Mappers;

namespace CTH.BLL
{
    public class TraduccionLogic
    {

        public List<Traducido> Traducidos(string form, int language)
        {
            MapperTraduccion mapperTraduccion = new MapperTraduccion();
            return mapperTraduccion.getTraducidos(form,language);
        }
    }
}
