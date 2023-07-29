using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.DAL.Mappers;
using CTH.Servicios.Enum;
using CTH.Servicios;

namespace CTH.BLL
{
    public class PermisosLogic
    {
        MapperPermiso _permisos;
        public PermisosLogic()
        {
            _permisos = new MapperPermiso();
        }
        public bool Existe(Componente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }
        public Array GetAllPermission()
        {
            return _permisos.GetAllPermission();
        }


        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            ServiceLogic.saveBitacora(SessionManager.GetInstance.Usuario, MotivoBitacora.CreacionDePatente);
            return _permisos.GuardarComponenete(p, esfamilia);
        }
        public void GuardarFamilia(Familia c)
        {
            ServiceLogic.saveBitacora(SessionManager.GetInstance.Usuario, MotivoBitacora.CreacionDeFamilia);
            _permisos.GuardarFamilia(c);
        }

        public IList<Patente> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }

        public IList<Familia> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }
        public IList<Componente> GetAll(string familia)
        {
            return _permisos.GetAll(familia);

        }

        public void FillUserComponents(UsuarioView u)
        {
            _permisos.FillUserComponents(u);

        }

        public void FillUserComponents(Usuario u)
        {
            _permisos.FillUserComponents(u);

        }

        public void FillFamilyComponents(Familia familia)
        {
            _permisos.FillFamilyComponents(familia);
        }

    }
}
