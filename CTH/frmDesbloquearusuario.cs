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
using CTH.BLL;
using CTH.Servicios;
using CTH.Servicios.Enum;


namespace CTH
{
    public partial class frmDesbloquearusuario : Form
    {
        public frmDesbloquearusuario()
        {
            InitializeComponent();
        }
        Usuario usuario;

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            usuario= usuarioLogic.GetUsuario(txtbusqueda.Text);
            if (usuario != null)
            {
                txtnombre.Text = usuario.nombre;
                txtapellido.Text = usuario.apellido;
                txtusernamo.Text = usuario.getUserName;

                if (usuario.bloqueo)
                {
                    txtestado.Text = "BLOQUEADO";
                    txtestado.BackColor = Color.Red;
                    txtestado.ForeColor = Color.White;
                    btndesbloquear.Enabled = true;
                }
                else
                {
                    txtestado.Text = "HABILITADO";
                    txtestado.BackColor = Color.Green;
                    txtestado.ForeColor = Color.Black;
                }
            }
        }

        private void btndesbloquear_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            if (usuarioLogic.DesbloquearUsuario(txtbusqueda.Text))
            {
                btndesbloquear.Enabled = false;
                ServiceLogic.saveBitacora(usuario, MotivoBitacora.usuarioDesbloqueado);
                MessageBox.Show("Informacion", "El usuario quedo habilitado", MessageBoxButtons.OK);
            }
            else
            {
                ServiceLogic.saveBitacora(usuario, MotivoBitacora.ErrorEnDesloqueo);
                MessageBox.Show("Error", "Ocurrio un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
