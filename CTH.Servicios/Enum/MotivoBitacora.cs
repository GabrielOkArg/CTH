using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.Servicios.Enum
{
    public enum MotivoBitacora
    {
        InicioSesionExitoso,
        FalloInicioSesion,
        CreacionRegistro,
        ModificacionRegistro,
        EliminacionRegistro,
        ErrorEjecucion,
        ExcepcionNoControlada,
        AccesoNoAutorizado,
        CambioConfiguracion,
        ConsultaBDExitosa,
        ErrorConsultaBD,
        AccesoRecursoNoPermitido,
        EventoImportanciaCritica,
        ProcesoSegundoPlano,
        CambioArchivoCarpeta,
        EventoSeguridad,
        AlertaSistema,
        SeguimientoAuditoria,
        CargaDescargaDatos,
        usuarioBloqueado3intentos,
        usuarioDesbloqueado,
        ErrorEnDesloqueo,
        CambioDeContraseña,
        CreacionDePatente,
        CreacionDeFamilia,
        ConfiguracionDeFamilia,
        CreacionOrdenTrabajo,
        NuevaSolicitudCreada
    }

}
