namespace Presentation.Forms.Mentenimiento
{
    partial class Permisos
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
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Dashboard");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Agregar");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Modificar");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Eliminar");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Pedidos", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Reportes");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Agregar");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Modificar");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Eliminar");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Clientes", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Agregar");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Modificar");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Eliminar");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Empleados", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Configurar");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Respaldar");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("DB", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Gestionar usuarios");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Grupos de usuarios");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Permisos");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Cambiar contraseña");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Administracion", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Mantenimiento", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode45});
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 47);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "PERMISOS:";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 47);
            this.treeView1.Name = "treeView1";
            treeNode24.Name = "Nodo5";
            treeNode24.Text = "Dashboard";
            treeNode25.Name = "Nodo6";
            treeNode25.Text = "Agregar";
            treeNode26.Name = "Nodo7";
            treeNode26.Text = "Modificar";
            treeNode27.Name = "Nodo8";
            treeNode27.Text = "Eliminar";
            treeNode28.Name = "Nodo0";
            treeNode28.Text = "Pedidos";
            treeNode29.Name = "Nodo1";
            treeNode29.Text = "Reportes";
            treeNode30.Name = "Nodo9";
            treeNode30.Text = "Agregar";
            treeNode31.Name = "Nodo10";
            treeNode31.Text = "Modificar";
            treeNode32.Name = "Nodo11";
            treeNode32.Text = "Eliminar";
            treeNode33.Name = "Nodo2";
            treeNode33.Text = "Clientes";
            treeNode34.Name = "Nodo12";
            treeNode34.Text = "Agregar";
            treeNode35.Name = "Nodo13";
            treeNode35.Text = "Modificar";
            treeNode36.Name = "Nodo14";
            treeNode36.Text = "Eliminar";
            treeNode37.Name = "Nodo3";
            treeNode37.Text = "Empleados";
            treeNode38.Name = "Nodo17";
            treeNode38.Text = "Configurar";
            treeNode39.Name = "Nodo18";
            treeNode39.Text = "Respaldar";
            treeNode40.Name = "Nodo16";
            treeNode40.Text = "DB";
            treeNode41.Name = "Nodo20";
            treeNode41.Text = "Gestionar usuarios";
            treeNode42.Name = "Nodo22";
            treeNode42.Text = "Grupos de usuarios";
            treeNode43.Name = "Nodo24";
            treeNode43.Text = "Permisos";
            treeNode44.Name = "Nodo23";
            treeNode44.Text = "Cambiar contraseña";
            treeNode45.Name = "Nodo19";
            treeNode45.Text = "Administracion";
            treeNode46.Name = "Nodo4";
            treeNode46.Text = "Mantenimiento";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode28,
            treeNode29,
            treeNode33,
            treeNode37,
            treeNode46});
            this.treeView1.Size = new System.Drawing.Size(203, 403);
            this.treeView1.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "------------------------------"});
            this.listBox2.Location = new System.Drawing.Point(209, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 368);
            this.listBox2.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "------------------------------"});
            this.listBox1.Location = new System.Drawing.Point(578, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 368);
            this.listBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(209, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuarios y Grupos de usuarios disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(578, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Usuarios y Grupos de usuarios habilitados:";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnHome.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 50;
            this.btnHome.Location = new System.Drawing.Point(483, 91);
            this.btnHome.Name = "btnHome";
            this.btnHome.Rotation = 180D;
            this.btnHome.Size = new System.Drawing.Size(89, 77);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "Habilitar";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(483, 194);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(89, 73);
            this.iconButton1.TabIndex = 32;
            this.iconButton1.Text = "Deshabilitar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}