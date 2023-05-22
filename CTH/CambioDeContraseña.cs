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
    public partial class CambioDeContraseña : Form
    {
        public CambioDeContraseña()
        {
            InitializeComponent();
        }
        private void ValidarBoton()
        {
            if (txtpassoriginal.Text == "" && txtnueva.Text == "" && txtrepeticion.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpassoriginal_TextChanged(object sender, EventArgs e)
        {
            ValidarBoton();
        }

        private void txtnueva_TextChanged(object sender, EventArgs e)
        {
            ValidarBoton();
        }

        private void txtrepeticion_TextChanged(object sender, EventArgs e)
        {
            ValidarBoton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnueva.Text!=txtrepeticion.Text )
                {
                    throw new Exception("La contraseña nueva debe ser igual em ambos campos");
                }
                else
                {
                    UsuarioLogic usuarioLogic = new UsuarioLogic();
                    usuarioLogic.CambiarContraseña(txtpassoriginal.Text,txtnueva.Text);
                    MessageBox.Show("la contraseña se actualizo correctamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Informacion");
            }
        }
    }
}
