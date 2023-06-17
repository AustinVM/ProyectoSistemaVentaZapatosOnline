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
            PnlBotones = new Panel();
            BtnCerrarSesion = new Button();
            BtnUsuario = new Button();
            BtnProductos = new Button();
            BtnFacturas = new Button();
            BtnPedidos = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            crearNuevoUsuarioToolStripMenuItem = new ToolStripMenuItem();
            crearYEditarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            crearRolesToolStripMenuItem = new ToolStripMenuItem();
            PnlOpciones = new Panel();
            PnlBotones.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlBotones
            // 
            PnlBotones.BackColor = Color.FromArgb(0, 122, 204);
            PnlBotones.Controls.Add(BtnCerrarSesion);
            PnlBotones.Controls.Add(BtnUsuario);
            PnlBotones.Controls.Add(BtnProductos);
            PnlBotones.Controls.Add(BtnFacturas);
            PnlBotones.Controls.Add(BtnPedidos);
            PnlBotones.Dock = DockStyle.Left;
            PnlBotones.Location = new Point(0, 0);
            PnlBotones.Name = "PnlBotones";
            PnlBotones.Size = new Size(244, 615);
            PnlBotones.TabIndex = 0;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.BackColor = Color.FromArgb(40, 40, 40);
            BtnCerrarSesion.Cursor = Cursors.Hand;
            BtnCerrarSesion.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            BtnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCerrarSesion.ForeColor = Color.Silver;
            BtnCerrarSesion.Location = new Point(12, 563);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(221, 40);
            BtnCerrarSesion.TabIndex = 13;
            BtnCerrarSesion.Text = "CERRAR SESION";
            BtnCerrarSesion.UseVisualStyleBackColor = false;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.BackColor = Color.FromArgb(40, 40, 40);
            BtnUsuario.Cursor = Cursors.Hand;
            BtnUsuario.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnUsuario.FlatAppearance.BorderSize = 0;
            BtnUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnUsuario.FlatStyle = FlatStyle.Flat;
            BtnUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnUsuario.ForeColor = Color.Silver;
            BtnUsuario.Location = new Point(12, 138);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(221, 40);
            BtnUsuario.TabIndex = 12;
            BtnUsuario.Text = "USUARIO";
            BtnUsuario.UseVisualStyleBackColor = false;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // BtnProductos
            // 
            BtnProductos.BackColor = Color.FromArgb(40, 40, 40);
            BtnProductos.Cursor = Cursors.Hand;
            BtnProductos.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnProductos.FlatAppearance.BorderSize = 0;
            BtnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnProductos.ForeColor = Color.Silver;
            BtnProductos.Location = new Point(12, 202);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(221, 40);
            BtnProductos.TabIndex = 11;
            BtnProductos.Text = "PRODUCTOS";
            BtnProductos.UseVisualStyleBackColor = false;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // BtnFacturas
            // 
            BtnFacturas.BackColor = Color.FromArgb(40, 40, 40);
            BtnFacturas.Cursor = Cursors.Hand;
            BtnFacturas.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnFacturas.FlatAppearance.BorderSize = 0;
            BtnFacturas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnFacturas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnFacturas.FlatStyle = FlatStyle.Flat;
            BtnFacturas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFacturas.ForeColor = Color.Silver;
            BtnFacturas.Location = new Point(12, 330);
            BtnFacturas.Name = "BtnFacturas";
            BtnFacturas.Size = new Size(221, 40);
            BtnFacturas.TabIndex = 10;
            BtnFacturas.Text = "FACTURAS";
            BtnFacturas.UseVisualStyleBackColor = false;
            // 
            // BtnPedidos
            // 
            BtnPedidos.BackColor = Color.FromArgb(40, 40, 40);
            BtnPedidos.Cursor = Cursors.Hand;
            BtnPedidos.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnPedidos.FlatAppearance.BorderSize = 0;
            BtnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnPedidos.FlatStyle = FlatStyle.Flat;
            BtnPedidos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPedidos.ForeColor = Color.Silver;
            BtnPedidos.Location = new Point(12, 266);
            BtnPedidos.Name = "BtnPedidos";
            BtnPedidos.Size = new Size(221, 40);
            BtnPedidos.TabIndex = 9;
            BtnPedidos.Text = "PEDIDOS";
            BtnPedidos.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 122, 204);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 106);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(390, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 122, 204);
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearNuevoUsuarioToolStripMenuItem, crearRolesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(250, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // crearNuevoUsuarioToolStripMenuItem
            // 
            crearNuevoUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearYEditarUsuariosToolStripMenuItem, consultarUsuariosToolStripMenuItem, eliminarUsuariosToolStripMenuItem });
            crearNuevoUsuarioToolStripMenuItem.ForeColor = Color.White;
            crearNuevoUsuarioToolStripMenuItem.Name = "crearNuevoUsuarioToolStripMenuItem";
            crearNuevoUsuarioToolStripMenuItem.Size = new Size(88, 25);
            crearNuevoUsuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // crearYEditarUsuariosToolStripMenuItem
            // 
            crearYEditarUsuariosToolStripMenuItem.Name = "crearYEditarUsuariosToolStripMenuItem";
            crearYEditarUsuariosToolStripMenuItem.Size = new Size(252, 26);
            crearYEditarUsuariosToolStripMenuItem.Text = "Crear y Editar Usuarios";
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            consultarUsuariosToolStripMenuItem.Size = new Size(252, 26);
            consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            eliminarUsuariosToolStripMenuItem.Size = new Size(252, 26);
            eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            // 
            // crearRolesToolStripMenuItem
            // 
            crearRolesToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            crearRolesToolStripMenuItem.Name = "crearRolesToolStripMenuItem";
            crearRolesToolStripMenuItem.Size = new Size(63, 25);
            crearRolesToolStripMenuItem.Text = "Roles";
            // 
            // PnlOpciones
            // 
            PnlOpciones.Dock = DockStyle.Fill;
            PnlOpciones.Location = new Point(244, 0);
            PnlOpciones.Name = "PnlOpciones";
            PnlOpciones.Size = new Size(990, 615);
            PnlOpciones.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1234, 615);
            Controls.Add(PnlOpciones);
            Controls.Add(PnlBotones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            PnlBotones.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlBotones;
        private Button BtnPedidos;
        private Button BtnFacturas;
        private Panel panel2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem crearYEditarUsuariosToolStripMenuItem;
        private ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearRolesToolStripMenuItem;
        private Button BtnUsuario;
        private Button BtnProductos;
        private Button BtnCerrarSesion;
        private Panel PnlOpciones;
    }
}