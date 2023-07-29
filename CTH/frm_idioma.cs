using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CTH.Servicios.Multiidioma;
using CTH.Servicios;
using CTH.BE;

namespace CTH
{
    public partial class frm_idioma_NuevoIdioma : Form,Iobserver
    {
        public frm_idioma_NuevoIdioma()
        {
            InitializeComponent();
        }
        private void frm_idioma_Load(object sender, EventArgs e)
        {
            cmb_formularios.DataSource = getAllForms();
        }


        private List<string> getAllForms()
        {
            List<string> forms = new List<string>();
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            foreach (Type item in types)
            {
                if (item.IsSubclassOf(typeof(Form)))
                {
                    Form form = (Form)Activator.CreateInstance(item);
                    forms.Add(form.Name);
                }
            }
            return forms;
        }

        private List<string> getAllControls(string formName)
        {
            List<string> names = new List<string>();
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            foreach (Type item in types)
            {
                if (item.IsSubclassOf(typeof(Form)))
                {
                    Form form = (Form)Activator.CreateInstance(item);
                    if (formName == form.Name)
                    {
                        foreach (Control control in form.Controls)
                        {
                            if (control.HasChildren)
                            {
                               getAllControls(control.Name);
                            }
                            else
                            {
                                names.Add(control.Name);
                            }

                        }
                    }
                    
                }
            }
            return names;

        }

        private void selectedFormChange(object sender, EventArgs e)
        {
            cmb_controles.DataSource = getAllControls(cmb_formularios.SelectedValue.ToString());
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }
    }
}
