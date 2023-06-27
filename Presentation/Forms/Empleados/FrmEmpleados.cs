using Presentation.Forms.Clientes.SubForms;
using Presentation.Forms.Empleados.EmpleadosForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            GrupoEmpleado formulario = GrupoEmpleado.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            AreaEmpleado formulario = AreaEmpleado.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleEmpleado formulario = DetalleEmpleado.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }
    }
}
