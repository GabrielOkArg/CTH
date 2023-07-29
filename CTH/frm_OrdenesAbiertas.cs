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
    public partial class frm_OrdenesAbiertas : Form, Iobserver
    {
        public frm_OrdenesAbiertas()
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

        private void frm_OrdenesAbiertas_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Noptify(IdiomaManager.getIdioma.Idioma);
            OrdenLogic ordenLogic = new OrdenLogic();
            dgv_ordenes.DataSource = ordenLogic.getOrdenesCoordinador(SessionManager.GetInstance.Usuario.id);
        }

        
    }
}
