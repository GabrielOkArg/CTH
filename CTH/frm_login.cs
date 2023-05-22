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
using CTH.Servicios.Exceptions;

namespace CTH
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AssistanSession assistanSession = new AssistanSession();
                assistanSession.GetUsuario(txt_user.Text, txt_pass.Text);
                assistanSession.LogIn();
                frm_cth frm_Cth = (frm_cth)this.MdiParent;
                frm_Cth.ValidForm();
                this.Close();
            }
            catch (FalloLoginException fex)
            {
                MessageBox.Show(fex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
