namespace Presentation.Forms
{
    partial class FrmMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfigurarDB = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRespaldar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGrupoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMantenimiento = new System.Windows.Forms.Panel();
            this.btnCambiarContraseña = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(101)))), ((int)(((byte)(150)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDatosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfigurarDB,
            this.btnRespaldar});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.baseDeDatosToolStripMenuItem.Text = "Base de datos";
            // 
            // btnConfigurarDB
            // 
            this.btnConfigurarDB.Name = "btnConfigurarDB";
            this.btnConfigurarDB.Size = new System.Drawing.Size(180, 22);
            this.btnConfigurarDB.Text = "Configurar";
            this.btnConfigurarDB.Click += new System.EventHandler(this.btnConfigurarDB_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnGrupoUsuarios,
            this.btnPermisos,
            this.btnCambiarContraseña});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.usuariosToolStripMenuItem.Text = "Administrar";
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(180, 22);
            this.btnRespaldar.Text = "Respaldar";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(180, 22);
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnGrupoUsuarios
            // 
            this.btnGrupoUsuarios.Name = "btnGrupoUsuarios";
            this.btnGrupoUsuarios.Size = new System.Drawing.Size(180, 22);
            this.btnGrupoUsuarios.Text = "Grupos de usuarios";
            this.btnGrupoUsuarios.Click += new System.EventHandler(this.btnGrupoUsuarios_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(180, 22);
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMantenimiento.Location = new System.Drawing.Point(0, 24);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(800, 426);
            this.panelMantenimiento.TabIndex = 1;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(180, 22);
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConfigurarDB;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRespaldar;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnGrupoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnPermisos;
        private System.Windows.Forms.Panel panelMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem btnCambiarContraseña;
    }
}