using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.Servicios;
using CTH.DAL.Mappers;

namespace CTH.BLL
{
    public class MaterialesLogic
    {




        public List<Material> buscarMaterial(string cadena)
        {
            MapperMaterial mapperMaterial = new MapperMaterial();
            return mapperMaterial.searchMaterial(cadena);
        }
    }
}
