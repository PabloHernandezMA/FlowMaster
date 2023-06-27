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
    public partial class FrmLogin : Form
    {
        private static FrmLogin instancia;

        private FrmLogin()
        {
            InitializeComponent();
        }
        public static FrmLogin ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FrmLogin();
            }
            return instancia;
        }
    }
}
