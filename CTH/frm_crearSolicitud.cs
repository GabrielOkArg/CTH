using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTH.Servicios.Multiidioma;
using CTH.Servicios.Exceptions;
using CTH.BE;
using CTH.BLL;
using CTH.Servicios;

namespace CTH
{
    public partial class frm_crearSolicitud : Form, Iobserver
    {
        public frm_crearSolicitud()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_crearSolicitud_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Noptify(Servicios.IdiomaManager._idioma.Idioma);
            InfraestructuraLogic infraestructuraLogic = new InfraestructuraLogic();
            cmb_Edificios.DisplayMember = "nombre";
            cmb_Edificios.ValueMember = "id";
            cmb_Edificios.DataSource = infraestructuraLogic.Edificos();
           
            //cmb_Equipos.DisplayMember = "nombre";
            //cmb_Equipos .ValueMember = "id";
        }

        public void Update(Idioma idioma)
        {
            TraduccionLogic traduccionLogic = new TraduccionLogic();
            foreach (Traducido item in traduccionLogic.Traducidos(this.Name, Servicios.IdiomaManager.getIdioma.Idioma.id))
            {
                if (item.formulario == this.Name)
                {
                    foreach (Control _item in this.Controls)
                    {
                        if (item.item == _item.Name)
                        {
                            _item.Name = item.traduccion;
                        }
                    }
                }
            }
        }

        private void selectEdificio(object sender, EventArgs e)
        {
            cmb_sectores.DataSource = null;
            InfraestructuraLogic infraestructuraLogic = new InfraestructuraLogic();
            cmb_sectores.DisplayMember = "nombre";
            cmb_sectores.ValueMember = "id";
            cmb_sectores.DataSource = infraestructuraLogic.Sectores(Convert.ToInt32(cmb_Edificios.SelectedValue));
        }

        private void selectedSector(object sender, EventArgs e)
        {
            cmb_Equipos.DataSource = null;
            InfraestructuraLogic infraestructuraLogic = new InfraestructuraLogic();
            cmb_Equipos.DisplayMember = "nombre";
            cmb_Equipos.ValueMember="id";
            cmb_Equipos.DataSource = infraestructuraLogic.Equipos(Convert.ToInt32(cmb_sectores.SelectedValue));
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();
            solicitud.id_edificio = Convert.ToInt32(cmb_Edificios.SelectedValue);
            solicitud.id_sector = Convert.ToInt32(cmb_sectores.SelectedValue);
            solicitud.id = Convert.ToInt32(cmb_Equipos.SelectedValue);
            solicitud.id_equipo = Convert.ToInt32(cmb_Equipos.SelectedValue);
            solicitud.detalle = txt_Detalle.Text;
            solicitud.creador = SessionManager.GetInstance.Usuario;
            solicitud.id_creador = solicitud.creador.id;
            SolicituLogic solicituLogic = new SolicituLogic();
            solicituLogic.GuardarSolicitud(solicitud);
            MessageBox.Show("La solicitud se guardo con exito");
            this.Close();
        }
    }
}
