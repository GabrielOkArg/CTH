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
using CTH.Servicios.Multiidioma;

namespace CTH
{
    public partial class frm_SolicitudesCoordinador : Form, Iobserver
    {
        Solicitud solicitud = new Solicitud();
        public frm_SolicitudesCoordinador()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            TraduccionLogic traduccionLogic = new TraduccionLogic();
            foreach (Traducido item in traduccionLogic.Traducidos(this.Name, IdiomaManager.getIdioma.Idioma.id))
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

        private void frm_SolicitudesCoordinador_Load(object sender, EventArgs e)
        {
            SolicituLogic solicituLogic = new SolicituLogic();
            Subject.AddObserver(this);
            Subject.Noptify(IdiomaManager.getIdioma.Idioma);
            dgv_solicitudesCoordinador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_solicitudesCoordinador.DataSource = solicituLogic.getByEstado("Abierto");
            ConfigDGV();
        }


        private void ConfigDGV()
        {
            dgv_solicitudesCoordinador.Columns["id"].Visible = true;
            dgv_solicitudesCoordinador.Columns["id"].HeaderText = "Num de Solicitud";

            dgv_solicitudesCoordinador.Columns["id_edificio"].Visible = false;
            dgv_solicitudesCoordinador.Columns["id_sector"].Visible = false;
            dgv_solicitudesCoordinador.Columns["id_equipo"].Visible = false;
            dgv_solicitudesCoordinador.Columns["id_creador"].Visible = false;
            dgv_solicitudesCoordinador.Columns["Creador"].Visible = false;

            dgv_solicitudesCoordinador.Columns["edificio"].HeaderText = "Edificio";
            dgv_solicitudesCoordinador.Columns["sector"].HeaderText = "Sector";
            dgv_solicitudesCoordinador.Columns["equipo"].HeaderText = "Equipo";
            dgv_solicitudesCoordinador.Columns["detalle"].HeaderText = "Detalle";
            dgv_solicitudesCoordinador.Columns["userName"].HeaderText = "Creador";
            dgv_solicitudesCoordinador.Columns["estado"].HeaderText = "Estado";
            dgv_solicitudesCoordinador.Columns["Creado"].HeaderText = "Creado";

          
        }

        private void dgv_solicitudesCoordinador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectedSolicitud(object sender, EventArgs e)
        {
            if (dgv_solicitudesCoordinador.SelectedRows.Count > 0)
            {
                DataGridViewRow selctedRequest = dgv_solicitudesCoordinador.SelectedRows[0];
                
                solicitud.detalle = selctedRequest.Cells["detalle"].Value.ToString();
                solicitud.id = Convert.ToInt32(selctedRequest.Cells["id"].Value.ToString());
                solicitud.estado = selctedRequest.Cells["Estado"].Value.ToString();
                solicitud.equipo = selctedRequest.Cells["Equipo"].Value.ToString();
                solicitud.edificio =selctedRequest.Cells["Edificio"].Value.ToString();
                solicitud.sector = selctedRequest.Cells["Sector"].Value.ToString();
                solicitud.userName = selctedRequest.Cells["userName"].Value.ToString();
                solicitud.id_sector = Convert.ToInt32(selctedRequest.Cells["id_sector"].Value.ToString());
                solicitud.id_edificio = Convert.ToInt32(selctedRequest.Cells["id_edificio"].Value.ToString());
                solicitud.id_equipo = Convert.ToInt32(selctedRequest.Cells["id_equipo"].Value.ToString());
                solicitud.Creado = Convert.ToDateTime(selctedRequest.Cells["Creado"].Value.ToString());
                txt_Detalle.Text = "";
                txt_Detalle.Text = solicitud.detalle;
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            frm_nueva_ot frm_Nueva_Ot = new frm_nueva_ot(solicitud);
           
            frm_Nueva_Ot.Show(); 
        }
    }
}
