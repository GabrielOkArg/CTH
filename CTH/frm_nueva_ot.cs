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
using CTH.Servicios.Multiidioma;
using CTH.Servicios;

namespace CTH
{
    public partial class frm_nueva_ot : Form, Iobserver
    {
        Solicitud actualSolicitud;
        List<Material> materials;
        UsuarioView tecnico;
        public frm_nueva_ot(Solicitud solicitud)
        {
            InitializeComponent();
            actualSolicitud = solicitud;
            //UsuarioLogic usuario = new UsuarioLogic();
            //PermisosLogic permisosLogic = new PermisosLogic();
            //List<UsuarioView> usuarios = usuario.GetAll();
       
            //List<UsuarioView> usuarioViews = new List<UsuarioView>();
            //UsuarioView opcionSeleccionarTecnico = new UsuarioView { nombre = "Seleccione un técnico", };
            //foreach (UsuarioView item in usuarios)
            //{
            //    permisosLogic.FillUserComponents(item);
            //    if (IsInRole(TipoPermiso.Tecnico,item))
            //    {
            //        usuarioViews.Add(item);
            //    }
            //}
            //usuarioViews.Add(opcionSeleccionarTecnico);

            //cb_asignartecnico.DataSource = usuarioViews;

            materials = new List<Material>();
        }

        private void grpb_datosDeLaSolicitud_Enter(object sender, EventArgs e)
        {

        }
        bool isInRole(Componente c, TipoPermiso permiso, bool existe)
        {


            if (c.Permiso.Equals(permiso))
                existe = true;
            else
            {
                foreach (var item in c.Hijos)
                {
                    existe = isInRole(item, permiso, existe);
                    if (existe) return true;
                }
            }

            return existe;
        }

        public bool IsInRole(TipoPermiso permiso, UsuarioView usuario)
        {
            bool existe = false;
            foreach (var item in usuario.Permisos)
            {
                if (item.Permiso.Equals(permiso))
                    return true;
                else
                {
                    existe = isInRole(item, permiso, existe);
                    if (existe) return true;
                }

            }

            return existe;
        }

        private void frm_nueva_ot_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Noptify(IdiomaManager.getIdioma.Idioma);
            lbl_datoEdificio.Text = actualSolicitud.edificio;
            lbl_datoSector.Text = actualSolicitud.sector;
            lbl_datoequipo.Text = (string.IsNullOrEmpty(actualSolicitud.equipo))?"N/A": actualSolicitud.equipo;
            lbl_datoFecha.Text = actualSolicitud.Creado.ToString();
            lbl_datoSolicitante.Text = actualSolicitud.userName;
            txt_datoDetalle.Text = actualSolicitud.detalle;


            UsuarioLogic usuario = new UsuarioLogic();
            PermisosLogic permisosLogic = new PermisosLogic();
            List<UsuarioView> usuarios = usuario.GetAll();
            List<UsuarioView> usuarioViews = new List<UsuarioView>();
            UsuarioView opcionSeleccionarTecnico = new UsuarioView { username = "Seleccione un técnico", };
            usuarioViews.Add(opcionSeleccionarTecnico);
            foreach (UsuarioView item in usuarios)
            {
                permisosLogic.FillUserComponents(item);
                if (IsInRole(TipoPermiso.Tecnico, item))
                {
                    usuarioViews.Add(item);
                }
            }
           

            cb_asignartecnico.DataSource = usuarioViews;


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

        private void lbl_fechasolicitud_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialesLogic materialesLogic = new MaterialesLogic();
            lbx_materialResultado.DataSource = materialesLogic.buscarMaterial(txtNombreMaterial.Text);
            lbx_materialResultado.DisplayMember = "nombre";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(InputDialog.Show("Cantidad de material", "ingrese la cantidad"));
            Material material = (Material)lbx_materialResultado.SelectedItem;
            material.cantidad = cantidad;
            materials.Add(material);
            lbxMaterialesAgregador.DataSource = null;
            lbxMaterialesAgregador.DataSource = materials;
            lbxMaterialesAgregador.DisplayMember = "MaterialCantidad";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OrdenTrabajo orden = new OrdenTrabajo();
            DateTime dateTime = DateTime.Now;
            orden.fechacreacion = dateTime;
            orden.cordinadorId = SessionManager.GetInstance.Usuario.id;
            orden.detalleCoordinador = txt_detalletecnico.Text;
            orden.tecnicoId =tecnico.Id;
            orden.solicitud_id = actualSolicitud.id;
            
            OrdenLogic ordenLogic = new OrdenLogic();
            ordenLogic.guardarOrden(orden, materials);
            MessageBox.Show("La orden se genero con exito!", "Informacion");
            this.Close();
        }

        private void cb_asignartecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tecnico = (UsuarioView)cb_asignartecnico.SelectedItem;
            
        }
    }
}
