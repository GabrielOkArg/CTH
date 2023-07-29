using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTH.BE;
using CTH.Servicios;
using CTH.Servicios.Enciptacion;
using CTH.Servicios.Multiidioma;
using CTH.BLL;
using System.Reflection;

namespace CTH
{
    public partial class frm_cth : Form, Iobserver
    {
        public frm_cth()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            IsMdiContainer = true;
            cerrarSesionToolStripMenuItem.Visible = false;
            if (SessionManager.GetInstance == null)
            {
                cambiarContraseñaToolStripMenuItem.Visible = false;
            }
            Idioma idioma = new Idioma();
            idioma.id = 1;
            IdiomaManager.loadIdioma(idioma);

            ocultarMenuInicio();
            cmbIdioma.DataSource = loadComboLanguages();

        }

    

        private void ValidarPermisos()
        {
            this.moduloDeUsuariosToolStripMenuItem.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Administrador);
            this.solicitudesToolStripMenuItem.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Solicitante);
            this.coordinadorToolStripMenuItem.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Coordinador);
            this.tecnicoToolStripMenuItem.Visible = SessionManager.GetInstance.IsInRole(TipoPermiso.Tecnico);
        }

        private void ocultarMenuInicio()
        {
            this.moduloDeUsuariosToolStripMenuItem.Visible = false;
            this.solicitudesToolStripMenuItem.Visible = false;
            this.coordinadorToolStripMenuItem.Visible = false;
            this.tecnicoToolStripMenuItem.Visible = false;
        }

        private List<KeyValuePair<int,string>> loadComboLanguages()
        {
            IdiomaLogic idiomaLogic = new IdiomaLogic();
            List<KeyValuePair<int, string>> idiomas = new List<KeyValuePair<int, string>>();
            foreach (Idioma item in idiomaLogic.getIdiomas())
            {
                idiomas.Add(new KeyValuePair<int, string>(item.id, item._Idioma));
            }
            return idiomas;
        }

        private void frm_cth_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Noptify(IdiomaManager.getIdioma.Idioma);
        }

        private void iniciarSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            frm_Login.MdiParent = this;
            frm_Login.Show();
           
        }


        public void ValidForm()
        {
            if (SessionManager.GetInstance != null)
            {
                lbl_userLogin.Text = "Bienvenido " + SessionManager.GetInstance.Usuario.getUserName;

                iniciarSeToolStripMenuItem.Visible = false;
                cerrarSesionToolStripMenuItem.Visible = true;
                cambiarContraseñaToolStripMenuItem.Visible = true;
                ValidarPermisos();
            }
            else
            {
                lbl_userLogin.Text = "";
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se va a cerrar la sesion","cerrar session", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SessionManager.Logout();
                if (SessionManager.GetInstance == null)
                {
                    lbl_userLogin.Text = "";
                    iniciarSeToolStripMenuItem.Visible = true;
                    cerrarSesionToolStripMenuItem.Visible = false;
                    cambiarContraseñaToolStripMenuItem.Visible = false;
                    ocultarMenuInicio();
                }
            }
        }

        private void altaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltaUsuario  = new frmAltaUsuario();
            frmAltaUsuario.MdiParent = this;
            frmAltaUsuario.Show();

        }

        private void desbloquearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesbloquearusuario frmDesbloquearusuario = new frmDesbloquearusuario();
            frmDesbloquearusuario.MdiParent = this;
            frmDesbloquearusuario.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambioDeContraseña cambioDeContraseña = new CambioDeContraseña();
            cambioDeContraseña.MdiParent = this;
            cambioDeContraseña.Show();
        }

        private void misOrdenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        public void Update(Idioma idioma)
        {
            TraduccionLogic traduccionLogic = new TraduccionLogic();
            foreach(Traducido traducido in traduccionLogic.Traducidos(this.Name, IdiomaManager.getIdioma.Idioma.id))
            {
                if (traducido.formulario == this.Name)
                {

                    if ("inicioToolStripMenuItem" == traducido.item)
                    {
                        inicioToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("iniciarSeToolStripMenuItem" == traducido.item)
                    {
                        iniciarSeToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("cerrarSesionToolStripMenuItem" == traducido.item)
                    {
                        cerrarSesionToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("cambiarContraseñaToolStripMenuItem" == traducido.item)
                    {
                        cambiarContraseñaToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("moduloDeUsuariosToolStripMenuItem" == traducido.item)
                    {
                        moduloDeUsuariosToolStripMenuItem.Text = traducido.traduccion;
                    }

                    if ("altaDeUsuarioToolStripMenuItem" == traducido.item)
                    {
                        altaDeUsuarioToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("desbloquearUsuarioToolStripMenuItem" == traducido.item)
                    {
                        desbloquearUsuarioToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("solicitudesToolStripMenuItem" == traducido.item)
                    {
                        solicitudesToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("crearSolicitudToolStripMenuItem" == traducido.item)
                    {
                        crearSolicitudToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("verMisSolicitudesToolStripMenuItem" == traducido.item)
                    {
                        verMisSolicitudesToolStripMenuItem.Text = traducido.traduccion;
                    }


                    if ("coordinadorToolStripMenuItem" == traducido.item)
                    {
                        coordinadorToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("solicitudesToolStripMenuItem1" == traducido.item)
                    {
                        solicitudesToolStripMenuItem1.Text = traducido.traduccion;
                    }
                    if ("verOTCerradasToolStripMenuItem" == traducido.item)
                    {
                        verOTCerradasToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("informeDeEquipoToolStripMenuItem" == traducido.item)
                    {
                        informeDeEquipoToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("equipoToolStripMenuItem" == traducido.item)
                    {
                        equipoToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("tecnicosToolStripMenuItem" == traducido.item)
                    {
                        tecnicosToolStripMenuItem.Text = traducido.traduccion;
                    }

                    if ("tecnicoToolStripMenuItem" == traducido.item)
                    {
                        tecnicoToolStripMenuItem.Text = traducido.traduccion;
                    }
                    if ("misOrdenesDeTrabajoToolStripMenuItem" == traducido.item)
                    {
                        misOrdenesDeTrabajoToolStripMenuItem.Text = traducido.traduccion;
                    }

                    if ("nuevoIdiomaToolStripMenuItem" == traducido.item)
                    {
                        nuevoIdiomaToolStripMenuItem.Text = traducido.traduccion;
                    }
                    



                }
            }

        }

        private void menuIdiomas_Click(object sender, EventArgs e)
        {
            
        }

        private void menuidioma_Selected(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem toolStripItem = (ToolStripItem)sender;
       
      
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectedItem(object sender, EventArgs e)
        {
           string cadena = cmbIdioma.SelectedValue.ToString();
            int inicio = cadena.IndexOf("[") + 1; // Índice del inicio del número
            int fin = cadena.IndexOf(","); // Índice del final del número
           // MessageBox.Show(cadena.Substring(inicio, fin - inicio));

            IdiomaManager.ClearIdioma();
            Idioma idioma = new Idioma();
            idioma.id = Convert.ToInt32(cadena.Substring(inicio, fin - inicio));
            IdiomaManager.loadIdioma(idioma);
            Subject.Noptify(idioma);
        }

        private void Frm_home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Subject.RemoveObserver(this);
        }

        private void nuevoIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_idioma_NuevoIdioma frm_Idioma = new frm_idioma_NuevoIdioma();
            frm_Idioma.MdiParent = this;
            frm_Idioma.Show();
        }

        private void crearSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_crearSolicitud frm_CrearSolicitud = new frm_crearSolicitud();
            frm_CrearSolicitud.MdiParent = this;
            frm_CrearSolicitud.Show();
        }

        private void verMisSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_misSolicitudes frm_MisSolicitudes = new frm_misSolicitudes();
            frm_MisSolicitudes.MdiParent = this;
            frm_MisSolicitudes.Show();
        }

        private void perfilesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FamiliaPatente frm_FamiliaPatente = new frm_FamiliaPatente();
            frm_FamiliaPatente.MdiParent = this;
            frm_FamiliaPatente.Show();
        }

        private void configurarPermisosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuarios frm_Usuarios = new frm_usuarios();
            frm_Usuarios.MdiParent = this;
            frm_Usuarios.Show();
        }

        private void solicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_SolicitudesCoordinador frm_SolicitudesCoordinador = new frm_SolicitudesCoordinador();
            frm_SolicitudesCoordinador.MdiParent = this;
            frm_SolicitudesCoordinador.Show();
        }

        private void verOTCerradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OrdenesAbiertas frm_OrdenesAbiertas = new frm_OrdenesAbiertas();
            frm_OrdenesAbiertas.MdiParent = this;
            frm_OrdenesAbiertas.Show();
        }
    }
}
