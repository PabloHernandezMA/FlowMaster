using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Forms.Mentenimiento;

namespace Presentation.Forms
{
    public partial class FrmMantenimiento : Form
    {
        private Form currentChildForm;

        public FrmMantenimiento()
        {
            InitializeComponent();
        }
        
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMantenimiento.Controls.Add(childForm);
            panelMantenimiento.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panelMantenimiento.Text = childForm.Text;
        }

        //Menu Button_Clicks
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios());
        }
        private void btnGrupoUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GruposUsuarios());
        }
        private void btnPermisos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Permisos());
        }
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CambiarContraseña());
        }
        private void btnConfigurarDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DBconfig());
        }
    }
}
