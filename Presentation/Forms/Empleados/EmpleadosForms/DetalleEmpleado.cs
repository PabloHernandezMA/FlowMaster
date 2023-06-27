using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Empleados.EmpleadosForms
{
    public partial class DetalleEmpleado : Form
    {
        private static DetalleEmpleado instancia;
        
        private DetalleEmpleado()
        {
            InitializeComponent();
        }

        public static DetalleEmpleado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new DetalleEmpleado();
            }
            return instancia;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
