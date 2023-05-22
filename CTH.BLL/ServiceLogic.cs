using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL.Mappers;
using CTH.Servicios;
using CTH.Servicios.Enum;

namespace CTH.BLL
{
    public static class ServiceLogic
    {



        public static void saveBitacora(Usuario usuario, MotivoBitacora motivo)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.motivo = motivo;
            bitacora.userName = usuario.getUserName;

            MapperService mapperService = new MapperService();
            mapperService.SaveBitacora(bitacora);
        }
    }
}
