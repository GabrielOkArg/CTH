using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.Servicios.Enum;
using CTH.DAL.Mappers;
using CTH.Servicios;


namespace CTH.BLL
{
    public class SolicituLogic
    {



        public void GuardarSolicitud(Solicitud solicitud)
        {
            try
            {
                MapperSolicitud mapperSolicitud = new MapperSolicitud();
                solicitud.estado = Estados.Abierto.ToString();
                mapperSolicitud.saveSolicitud(solicitud);
                ServiceLogic.saveBitacora(SessionManager.GetInstance.Usuario, MotivoBitacora.CreacionOrdenTrabajo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Solicitud> getAllByUserId(int id)
        {
            try
            {
                MapperSolicitud mapperSolicitud = new MapperSolicitud();
                return mapperSolicitud.getSolicitudesByUsuario(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Solicitud> getByEstado(string estado)
        {
            MapperSolicitud mapperSolicitud = new MapperSolicitud();
            return mapperSolicitud.getByEstado(estado);
        }
    }
}
