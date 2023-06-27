using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.Clientes.SubForms
{
    public partial class DetalleCliente : Form
    {
        private static DetalleCliente instancia;

        private DetalleCliente()
        {
            InitializeComponent();
        }

        public static DetalleCliente ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new DetalleCliente();
            }
            return instancia;
        }
    }
}
