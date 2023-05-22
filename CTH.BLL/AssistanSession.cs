using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.Servicios;
using CTH.BE;
using CTH.DAL.Mappers;
using CTH.Servicios.Exceptions;
using CTH.Servicios.Enciptacion;
using CTH.Servicios.Enum;

namespace CTH.BLL
{
    public class AssistanSession
    {




        private Usuario _usuario_;
        private string _pass_;
        

        public void GetUsuario(string username, string pass)
        {
            _pass_ = pass;
           
            MapperUsuario mapperUsuario = new MapperUsuario();
            Usuario usuario = new Usuario(username);
            _usuario_ = mapperUsuario.GetByElement(usuario);
            if (_usuario_==null)
            {
                throw new FalloLoginException("El usuario es inexistente verifiquelo y vuelva a intentarlo");
            }
        }

        private void Block()
        {
                MapperUsuario mapperUsuario = new MapperUsuario();
                mapperUsuario.BloquearUsuario(_usuario_.getUserName);
                 ServiceLogic.saveBitacora(_usuario_, MotivoBitacora.usuarioBloqueado3intentos);
                throw new FalloLoginException("Se supero el maximo de intentos, su usuario fue bloqueado comuniquese con el administrador");


          
        }

        public  void LogIn()
        {
          
                string passMD5 = Encriptacion.GetMD5(_pass_);
            MapperUsuario mapperUsuario = new MapperUsuario();
            if (_usuario_ != null)
                {
                    if (_usuario_.pass == passMD5)
                    {
                        
                        if (!_usuario_.bloqueo)
                        {
                            SessionManager.Login(_usuario_);
                             mapperUsuario.updateIntentos(_usuario_.getUserName, EncriptacionData.Encriptar("0"));
                        //generar bitacora de login

                        ServiceLogic.saveBitacora(_usuario_, MotivoBitacora.InicioSesionExitoso);
                        }
                        else
                        {
                            throw new FalloLoginException("Su usuario se encuentra bloqueado");
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(EncriptacionData.Desencriptar(_usuario_.intentos) )== 2)
                        {
                            Block();
                        }
                        else
                        {
                             int intento = Convert.ToInt32(EncriptacionData.Desencriptar(_usuario_.intentos)) + 1;
                           
                             mapperUsuario.updateIntentos(_usuario_.getUserName, EncriptacionData.Encriptar(intento.ToString()));
                            throw new FalloLoginException("La contraseña es incoprrecta");
                        }


                    }
                   

                }

          
        }
    }
}
