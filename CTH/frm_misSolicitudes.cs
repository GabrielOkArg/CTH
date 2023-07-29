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
using CTH.Servicios.Exceptions;
using CTH.BLL;
using CTH.Servicios.Multiidioma;

namespace CTH
{
    public partial class frm_misSolicitudes : Form, Iobserver
    {
        public frm_misSolicitudes()
        {
            InitializeComponent();
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

        private void frm_misSolicitudes_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Noptify(Servicios.IdiomaManager._idioma.Idioma);
            dgv_misSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            SolicituLogic solicituLogic = new SolicituLogic();
            dgv_misSolicitudes.DataSource = solicituLogic.getAllByUserId(SessionManager.GetInstance.Usuario.id);
            ConfigDGV();

        }

        private void ConfigDGV()
        {
            dgv_misSolicitudes.Columns["id"].Visible = true;
            dgv_misSolicitudes.Columns["id"].HeaderText = "Num de Solicitud";

            dgv_misSolicitudes.Columns["id_edificio"].Visible = false;
            dgv_misSolicitudes.Columns["id_sector"].Visible = false;
            dgv_misSolicitudes.Columns["id_equipo"].Visible = false;
            dgv_misSolicitudes.Columns["id_creador"].Visible = false;

            dgv_misSolicitudes.Columns["edificio"].HeaderText = "Edificio";
            dgv_misSolicitudes.Columns["sector"].HeaderText = "Sector";
            dgv_misSolicitudes.Columns["equipo"].HeaderText = "Equipo";
            dgv_misSolicitudes.Columns["userName"].HeaderText = "Creador";
            dgv_misSolicitudes.Columns["estado"].HeaderText = "Estado";
            dgv_misSolicitudes.Columns["Creado"].HeaderText = "Creado";

        }
    }
}
