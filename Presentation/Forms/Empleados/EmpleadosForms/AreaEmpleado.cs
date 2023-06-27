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
    public partial class AreaEmpleado : Form
    {
        private static AreaEmpleado instancia;
        
        private AreaEmpleado()
        {
            InitializeComponent();
        }

        public static AreaEmpleado ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new AreaEmpleado();
            }
            return instancia;
        }
    }
}
