using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL.Mappers;

namespace CTH.BLL
{
    public class InfraestructuraLogic
    {



        public List<Edificio> Edificos()
        {
            InfraestructuraMapper infraestructuraMapper = new InfraestructuraMapper();
            return infraestructuraMapper.getEdificios();
        }

        public List<Sector> Sectores(int id)
        {
            InfraestructuraMapper infraestructuraMapper = new InfraestructuraMapper();
            return infraestructuraMapper.getSectoresByEdificio(id);
        }

        public List<Equipo> Equipos(int id)
        {
            InfraestructuraMapper infraestructuraMapper = new InfraestructuraMapper();
            return infraestructuraMapper.getEquiposBySector(id);
        }
    }
}
