using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.Servicios;
using CTH.DAL.Mappers;
using CTH.Servicios.Enum;

namespace CTH.BLL
{
    public class OrdenLogic
    {



        public List<OrdenTrabajo> getOrdenesAsignadas(int idtecnico)
        {
            MapperOT mapperOT = new MapperOT();
            List<OrdenTrabajo> ordenes = mapperOT.getOrdenesAsignadas(idtecnico);

            SolicituLogic solicituLogic = new SolicituLogic();
            foreach (Solicitud item in solicituLogic.getByEstado("Abierto"))
            {
                OrdenTrabajo temporal = ordenes.FirstOrDefault(x => x.solicitud_id == item.id);
                if (temporal != null)
                {
                    temporal.solicitud = item;
                }
               
            }
            return ordenes;
        }


        public List<OrdenTrabajo> getOrdenesCoordinador(int coordinado)
        {
            MapperOT mapperOT = new MapperOT();
            List<OrdenTrabajo> ordenes = mapperOT.getOrdenesCoordinador(coordinado);
            return ordenes;
        }


        public void guardarOrden(OrdenTrabajo ordenTrabajo, List<Material> materials)
        {
            MapperOT mapperOT = new MapperOT();
            mapperOT.saveOrden(ordenTrabajo, materials);
            ServiceLogic.saveBitacora(SessionManager.GetInstance.Usuario, MotivoBitacora.NuevaSolicitudCreada);
        }
    }
}
