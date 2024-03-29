﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using CTH.Servicios;
using CTH.Servicios.Enciptacion;
using CTH.DAL.Mappers;

namespace CTH.BLL
{
    public  class UsuarioLogic
    {


        public void CambiarContraseña( string origialpass,string newpass)
        {
           
            Usuario usuario = GetUsuario(SessionManager.GetInstance.Usuario.getUserName);
            if (usuario.pass != Encriptacion.GetMD5(origialpass)) throw new Exception("La contraseña ingresada no corresponde a la actual");
            if (usuario.pass == Encriptacion.GetMD5(newpass)) throw new Exception("La nueva contraseña no puede ser igual a la anterior");
            MapperUsuario usuarioMapper = new MapperUsuario();
            usuarioMapper.cambiarPass(usuario, Encriptacion.GetMD5(newpass));
            ServiceLogic.saveBitacora(usuario, Servicios.Enum.MotivoBitacora.CambioDeContraseña);
           
        }


        public void newUsuario(Usuario usuario)
        {
            Usuario existe = GetUsuario(usuario.getUserName);
            if (existe == null)
            {
                usuario.pass = Encriptacion.GetMD5(usuario.pass);
                usuario.intentos = EncriptacionData.Encriptar("0");
                usuario.bloqueo = false;
                MapperUsuario mapperUsuario = new MapperUsuario();
                mapperUsuario.saveUsuario(usuario);
            }
            else
            {
                throw new Exception("El nombre de usuario ya existe en el sistema ingrese otro");
            }
           
        }

        public Usuario GetUsuario(string username)
        {
            Usuario usuario = new Usuario(username);
            MapperUsuario mapperUsuario = new MapperUsuario();
            return mapperUsuario.GetByElement(usuario);
        }

        public bool DesbloquearUsuario(string username)
        {
            MapperUsuario mapperUsuario = new MapperUsuario();
           return mapperUsuario.DesbloquearUsuario(username);
        }

        public List<UsuarioView> GetAll()
        {
            MapperUsuario mapperUsuario = new MapperUsuario();
            return mapperUsuario.GetAllView();
        }

        public List<UsuarioView> getForCombo()
        {
            MapperUsuario mapperUsuario = new MapperUsuario();
            UsuarioView opcionSeleccionarTecnico = new UsuarioView { nombre = "Seleccione un técnico", };
            List<UsuarioView> lista = new List<UsuarioView>();
            lista.Add(opcionSeleccionarTecnico);
            foreach (UsuarioView item in mapperUsuario.GetAllView())
            {
                lista.Add(item);
            }
            return lista;
           
        }

        public void GuardarPermisos(UsuarioView u)
        {
            MapperUsuario mapperUsuario = new MapperUsuario();
            mapperUsuario.GuardarPermisos(u);
        }
    }
}
