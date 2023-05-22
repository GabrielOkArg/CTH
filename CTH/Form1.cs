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

namespace CTH
{
    public partial class frm_cth : Form
    {
        public frm_cth()
        {
            InitializeComponent();
            IsMdiContainer = true;
            cerrarSesionToolStripMenuItem.Visible = false;
            if (SessionManager.GetInstance == null)
            {
                cambiarContraseñaToolStripMenuItem.Visible = false;
            }

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
    }
}
