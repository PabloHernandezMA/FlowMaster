using Presentation.Forms.Clientes.SubForms;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            DetalleCliente formulario = DetalleCliente.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            DetalleCliente formulario = DetalleCliente.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DetalleCliente formulario = DetalleCliente.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {
            DetalleCliente formulario = DetalleCliente.ObtenerInstancia();
            formulario.BringToFront();
            formulario.Show();
        }
    }
}
