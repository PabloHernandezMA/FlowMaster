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

namespace Presentation.Forms.Empleados.EmpleadosForms
{
    public partial class GrupoEmpleado : Form
    {
        private static GrupoEmpleado instancia;
        private GrupoEmpleado()
        {
            InitializeComponent();
        }

        public static GrupoEmpleado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new GrupoEmpleado();
            }
            return instancia;
        }
    }
}
