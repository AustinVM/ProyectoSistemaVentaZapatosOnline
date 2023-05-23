namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
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
<<<<<<< HEAD
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.PnlOpciones = new System.Windows.Forms.Panel();
            this.PnlBotones.SuspendLayout();
=======
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.panel_Usuario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYEditarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
            this.SuspendLayout();
            // 
            // PnlBotones
            // 
<<<<<<< HEAD
            this.PnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.PnlBotones.Controls.Add(this.BtnFacturas);
            this.PnlBotones.Controls.Add(this.BtnPedidos);
            this.PnlBotones.Controls.Add(this.BtnSalir);
            this.PnlBotones.Controls.Add(this.BtnProductos);
            this.PnlBotones.Controls.Add(this.BtnUsuario);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBotones.Location = new System.Drawing.Point(0, 0);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(244, 642);
            this.PnlBotones.TabIndex = 0;
=======
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnProductos);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.BtnUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 615);
            this.panel1.TabIndex = 0;
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
            // 
            // BtnFacturas
            // 
<<<<<<< HEAD
            this.BtnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFacturas.ForeColor = System.Drawing.Color.Silver;
            this.BtnFacturas.Location = new System.Drawing.Point(12, 330);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(221, 40);
            this.BtnFacturas.TabIndex = 10;
            this.BtnFacturas.Text = "FACTURAS";
            this.BtnFacturas.UseVisualStyleBackColor = false;
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPedidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPedidos.ForeColor = System.Drawing.Color.Silver;
            this.BtnPedidos.Location = new System.Drawing.Point(12, 251);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(221, 40);
            this.BtnPedidos.TabIndex = 9;
            this.BtnPedidos.Text = "PEDIDOS";
            this.BtnPedidos.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(12, 578);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(221, 40);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnProductos.ForeColor = System.Drawing.Color.Silver;
            this.BtnProductos.Location = new System.Drawing.Point(12, 172);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(221, 40);
            this.BtnProductos.TabIndex = 7;
            this.BtnProductos.Text = "PRODUCTOS";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUsuario.ForeColor = System.Drawing.Color.Silver;
            this.BtnUsuario.Location = new System.Drawing.Point(12, 93);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(221, 40);
            this.BtnUsuario.TabIndex = 6;
            this.BtnUsuario.Text = "USUARIO";
            this.BtnUsuario.UseVisualStyleBackColor = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
=======
            this.BtnProductos.Location = new System.Drawing.Point(45, 142);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(136, 23);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(56, 547);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(136, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Location = new System.Drawing.Point(45, 100);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(136, 23);
            this.BtnUsuario.TabIndex = 1;
            this.BtnUsuario.Text = "Usuario";
            this.BtnUsuario.UseVisualStyleBackColor = true;
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
            // 
            // PnlOpciones
            // 
<<<<<<< HEAD
            this.PnlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOpciones.Location = new System.Drawing.Point(244, 0);
            this.PnlOpciones.Name = "PnlOpciones";
            this.PnlOpciones.Size = new System.Drawing.Size(990, 642);
            this.PnlOpciones.TabIndex = 1;
=======
            this.panel_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Usuario.Location = new System.Drawing.Point(250, 0);
            this.panel_Usuario.Name = "panel_Usuario";
            this.panel_Usuario.Size = new System.Drawing.Size(984, 615);
            this.panel_Usuario.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 106);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(390, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoUsuarioToolStripMenuItem,
            this.crearRolesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(250, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearNuevoUsuarioToolStripMenuItem
            // 
            this.crearNuevoUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearYEditarUsuariosToolStripMenuItem,
            this.consultarUsuariosToolStripMenuItem,
            this.eliminarUsuariosToolStripMenuItem});
            this.crearNuevoUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.crearNuevoUsuarioToolStripMenuItem.Name = "crearNuevoUsuarioToolStripMenuItem";
            this.crearNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.crearNuevoUsuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // crearYEditarUsuariosToolStripMenuItem
            // 
            this.crearYEditarUsuariosToolStripMenuItem.Name = "crearYEditarUsuariosToolStripMenuItem";
            this.crearYEditarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.crearYEditarUsuariosToolStripMenuItem.Text = "Crear y Editar Usuarios";
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            // 
            // crearRolesToolStripMenuItem
            // 
            this.crearRolesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearRolesToolStripMenuItem.Name = "crearRolesToolStripMenuItem";
            this.crearRolesToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.crearRolesToolStripMenuItem.Text = "Roles";
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1234, 642);
            this.Controls.Add(this.PnlOpciones);
            this.Controls.Add(this.PnlBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.PnlBotones.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(1234, 615);
            this.Controls.Add(this.panel_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlBotones;
        private Button BtnSalir;
        private Button BtnProductos;
<<<<<<< HEAD
        private Button BtnUsuario;
        private Button BtnPedidos;
        private Button BtnFacturas;
        private Panel PnlOpciones;
=======
        private Panel panel2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem crearYEditarUsuariosToolStripMenuItem;
        private ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearRolesToolStripMenuItem;
>>>>>>> a9183cb8fb99950d0497c9595c8c692eab84452d
    }
}