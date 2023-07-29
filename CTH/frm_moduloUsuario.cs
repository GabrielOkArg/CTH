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

namespace CTH
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frm_moduloUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private bool validForm()
        {
            if (txtpassA.Text !="" &&
                txtpassB.Text !="" &&
                txtpassA.Text == txtpassB.Text && txtnombre.Text != "" && txtapellido.Text != "" && txtusername.Text != "")
            {
                return true;
            }
            return false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validForm())
            {
                try
                {
                    Usuario usuario = new Usuario(txtusername.Text);
                    usuario.pass = txtpassA.Text;
                    usuario.nombre = txtnombre.Text;
                    usuario.apellido = txtapellido.Text;
                    UsuarioLogic usuarioLogic = new UsuarioLogic();
               
                    usuarioLogic.newUsuario(usuario);
                    MessageBox.Show("Se creo con exito el usuario", "Informacion");
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
