namespace CapaPresentacion.UsuarioSistema
{
    partial class Frm_Crear_Usuario
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
            this.crearNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYEditarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Gpb_roles = new System.Windows.Forms.GroupBox();
            this.Btn_editar_rol = new System.Windows.Forms.Button();
            this.Btn_guardar_rol = new System.Windows.Forms.Button();
            this.Dgv_roles = new System.Windows.Forms.DataGridView();
            this.Txb_nombre_rol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Gpb_insertar_usuario = new System.Windows.Forms.GroupBox();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CBX_rol = new System.Windows.Forms.ComboBox();
            this.Txb_confirmar_contraseña = new System.Windows.Forms.TextBox();
            this.TXB_Nombre_nuevo_usuario = new System.Windows.Forms.TextBox();
            this.Txb_Contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv_consultar_usuarios = new System.Windows.Forms.DataGridView();
            this.Btn_consultar_usuarios = new System.Windows.Forms.Button();
            this.Cmb_consultar_usuarios_roles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gpb_eliminar_usuarios = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.Gpb_consultar_usuarios = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.Gpb_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_roles)).BeginInit();
            this.Gpb_insertar_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultar_usuarios)).BeginInit();
            this.Gpb_eliminar_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gpb_consultar_usuarios.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(984, 29);
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
            this.crearYEditarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearYEditarUsuariosToolStripMenuItem_Click);
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuariosToolStripMenuItem_Click);
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            this.eliminarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosToolStripMenuItem_Click);
            // 
            // crearRolesToolStripMenuItem
            // 
            this.crearRolesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.crearRolesToolStripMenuItem.Name = "crearRolesToolStripMenuItem";
            this.crearRolesToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.crearRolesToolStripMenuItem.Text = "Roles";
            this.crearRolesToolStripMenuItem.Click += new System.EventHandler(this.crearRolesToolStripMenuItem_Click);
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
            // Gpb_roles
            // 
            this.Gpb_roles.Controls.Add(this.Btn_editar_rol);
            this.Gpb_roles.Controls.Add(this.Btn_guardar_rol);
            this.Gpb_roles.Controls.Add(this.Dgv_roles);
            this.Gpb_roles.Controls.Add(this.Txb_nombre_rol);
            this.Gpb_roles.Controls.Add(this.label8);
            this.Gpb_roles.Location = new System.Drawing.Point(12, 121);
            this.Gpb_roles.Name = "Gpb_roles";
            this.Gpb_roles.Size = new System.Drawing.Size(798, 432);
            this.Gpb_roles.TabIndex = 3;
            this.Gpb_roles.TabStop = false;
            // 
            // Btn_editar_rol
            // 
            this.Btn_editar_rol.Location = new System.Drawing.Point(230, 108);
            this.Btn_editar_rol.Name = "Btn_editar_rol";
            this.Btn_editar_rol.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar_rol.TabIndex = 14;
            this.Btn_editar_rol.Text = "Editar";
            this.Btn_editar_rol.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar_rol
            // 
            this.Btn_guardar_rol.Location = new System.Drawing.Point(110, 108);
            this.Btn_guardar_rol.Name = "Btn_guardar_rol";
            this.Btn_guardar_rol.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar_rol.TabIndex = 15;
            this.Btn_guardar_rol.Text = "Guardar";
            this.Btn_guardar_rol.UseVisualStyleBackColor = true;
            // 
            // Dgv_roles
            // 
            this.Dgv_roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_roles.Location = new System.Drawing.Point(177, 161);
            this.Dgv_roles.Name = "Dgv_roles";
            this.Dgv_roles.RowTemplate.Height = 25;
            this.Dgv_roles.Size = new System.Drawing.Size(240, 150);
            this.Dgv_roles.TabIndex = 18;
            // 
            // Txb_nombre_rol
            // 
            this.Txb_nombre_rol.Location = new System.Drawing.Point(404, 48);
            this.Txb_nombre_rol.Name = "Txb_nombre_rol";
            this.Txb_nombre_rol.Size = new System.Drawing.Size(121, 23);
            this.Txb_nombre_rol.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(77, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ingrese Nombre Del Rol Del Trabajador";
            // 
            // Gpb_insertar_usuario
            // 
            this.Gpb_insertar_usuario.Controls.Add(this.Btn_editar);
            this.Gpb_insertar_usuario.Controls.Add(this.label2);
            this.Gpb_insertar_usuario.Controls.Add(this.Dgv_usuarios);
            this.Gpb_insertar_usuario.Controls.Add(this.Btn_guardar);
            this.Gpb_insertar_usuario.Controls.Add(this.label5);
            this.Gpb_insertar_usuario.Controls.Add(this.CBX_rol);
            this.Gpb_insertar_usuario.Controls.Add(this.Txb_confirmar_contraseña);
            this.Gpb_insertar_usuario.Controls.Add(this.TXB_Nombre_nuevo_usuario);
            this.Gpb_insertar_usuario.Controls.Add(this.Txb_Contraseña);
            this.Gpb_insertar_usuario.Controls.Add(this.label3);
            this.Gpb_insertar_usuario.Controls.Add(this.label4);
            this.Gpb_insertar_usuario.Location = new System.Drawing.Point(12, 127);
            this.Gpb_insertar_usuario.Name = "Gpb_insertar_usuario";
            this.Gpb_insertar_usuario.Size = new System.Drawing.Size(798, 432);
            this.Gpb_insertar_usuario.TabIndex = 15;
            this.Gpb_insertar_usuario.TabStop = false;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(192, 394);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 9;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Del Usuario";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(448, 22);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.RowTemplate.Height = 25;
            this.Dgv_usuarios.Size = new System.Drawing.Size(337, 392);
            this.Dgv_usuarios.TabIndex = 8;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(55, 394);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 0;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cargo del Usuario";
            // 
            // CBX_rol
            // 
            this.CBX_rol.FormattingEnabled = true;
            this.CBX_rol.Location = new System.Drawing.Point(230, 311);
            this.CBX_rol.Name = "CBX_rol";
            this.CBX_rol.Size = new System.Drawing.Size(121, 23);
            this.CBX_rol.TabIndex = 1;
            // 
            // Txb_confirmar_contraseña
            // 
            this.Txb_confirmar_contraseña.Location = new System.Drawing.Point(230, 228);
            this.Txb_confirmar_contraseña.Name = "Txb_confirmar_contraseña";
            this.Txb_confirmar_contraseña.Size = new System.Drawing.Size(121, 23);
            this.Txb_confirmar_contraseña.TabIndex = 6;
            // 
            // TXB_Nombre_nuevo_usuario
            // 
            this.TXB_Nombre_nuevo_usuario.Location = new System.Drawing.Point(230, 62);
            this.TXB_Nombre_nuevo_usuario.Name = "TXB_Nombre_nuevo_usuario";
            this.TXB_Nombre_nuevo_usuario.Size = new System.Drawing.Size(121, 23);
            this.TXB_Nombre_nuevo_usuario.TabIndex = 2;
            // 
            // Txb_Contraseña
            // 
            this.Txb_Contraseña.Location = new System.Drawing.Point(230, 145);
            this.Txb_Contraseña.Name = "Txb_Contraseña";
            this.Txb_Contraseña.Size = new System.Drawing.Size(121, 23);
            this.Txb_Contraseña.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese una Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirme la Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 65);
            this.panel1.TabIndex = 1;
            // 
            // Dgv_consultar_usuarios
            // 
            this.Dgv_consultar_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultar_usuarios.Location = new System.Drawing.Point(16, 114);
            this.Dgv_consultar_usuarios.Name = "Dgv_consultar_usuarios";
            this.Dgv_consultar_usuarios.RowTemplate.Height = 25;
            this.Dgv_consultar_usuarios.Size = new System.Drawing.Size(769, 150);
            this.Dgv_consultar_usuarios.TabIndex = 0;
            // 
            // Btn_consultar_usuarios
            // 
            this.Btn_consultar_usuarios.Location = new System.Drawing.Point(427, 65);
            this.Btn_consultar_usuarios.Name = "Btn_consultar_usuarios";
            this.Btn_consultar_usuarios.Size = new System.Drawing.Size(75, 23);
            this.Btn_consultar_usuarios.TabIndex = 1;
            this.Btn_consultar_usuarios.Text = "Consultar";
            this.Btn_consultar_usuarios.UseVisualStyleBackColor = true;
            // 
            // Cmb_consultar_usuarios_roles
            // 
            this.Cmb_consultar_usuarios_roles.FormattingEnabled = true;
            this.Cmb_consultar_usuarios_roles.Location = new System.Drawing.Point(260, 65);
            this.Cmb_consultar_usuarios_roles.Name = "Cmb_consultar_usuarios_roles";
            this.Cmb_consultar_usuarios_roles.Size = new System.Drawing.Size(121, 23);
            this.Cmb_consultar_usuarios_roles.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(127, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filtar por Roles";
            // 
            // Gpb_eliminar_usuarios
            // 
            this.Gpb_eliminar_usuarios.Controls.Add(this.label7);
            this.Gpb_eliminar_usuarios.Controls.Add(this.comboBox1);
            this.Gpb_eliminar_usuarios.Controls.Add(this.dataGridView1);
            this.Gpb_eliminar_usuarios.Controls.Add(this.Btn_eliminar_usuario);
            this.Gpb_eliminar_usuarios.Location = new System.Drawing.Point(12, 121);
            this.Gpb_eliminar_usuarios.Name = "Gpb_eliminar_usuarios";
            this.Gpb_eliminar_usuarios.Size = new System.Drawing.Size(798, 426);
            this.Gpb_eliminar_usuarios.TabIndex = 16;
            this.Gpb_eliminar_usuarios.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(157, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filtar por Roles";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_eliminar_usuario
            // 
            this.Btn_eliminar_usuario.Location = new System.Drawing.Point(571, 57);
            this.Btn_eliminar_usuario.Name = "Btn_eliminar_usuario";
            this.Btn_eliminar_usuario.Size = new System.Drawing.Size(75, 23);
            this.Btn_eliminar_usuario.TabIndex = 1;
            this.Btn_eliminar_usuario.Text = "Eliminar";
            this.Btn_eliminar_usuario.UseVisualStyleBackColor = true;
            // 
            // Gpb_consultar_usuarios
            // 
            this.Gpb_consultar_usuarios.Controls.Add(this.label6);
            this.Gpb_consultar_usuarios.Controls.Add(this.Cmb_consultar_usuarios_roles);
            this.Gpb_consultar_usuarios.Controls.Add(this.Dgv_consultar_usuarios);
            this.Gpb_consultar_usuarios.Controls.Add(this.Btn_consultar_usuarios);
            this.Gpb_consultar_usuarios.Location = new System.Drawing.Point(12, 121);
            this.Gpb_consultar_usuarios.Name = "Gpb_consultar_usuarios";
            this.Gpb_consultar_usuarios.Size = new System.Drawing.Size(798, 438);
            this.Gpb_consultar_usuarios.TabIndex = 17;
            this.Gpb_consultar_usuarios.TabStop = false;
            // 
            // Frm_Crear_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gpb_insertar_usuario);
            this.Controls.Add(this.Gpb_roles);
            this.Controls.Add(this.Gpb_consultar_usuarios);
            this.Controls.Add(this.Gpb_eliminar_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Crear_Usuario";
            this.Text = "Fm_Crear_Usuario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gpb_roles.ResumeLayout(false);
            this.Gpb_roles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_roles)).EndInit();
            this.Gpb_insertar_usuario.ResumeLayout(false);
            this.Gpb_insertar_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultar_usuarios)).EndInit();
            this.Gpb_eliminar_usuarios.ResumeLayout(false);
            this.Gpb_eliminar_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gpb_consultar_usuarios.ResumeLayout(false);
            this.Gpb_consultar_usuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem crearYEditarUsuariosToolStripMenuItem;
        private ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private ToolStripMenuItem crearRolesToolStripMenuItem;
        private Label label1;
        private GroupBox Gpb_roles;
        private Panel panel1;
        private Label label6;
        private ComboBox Cmb_consultar_usuarios_roles;
        private Button Btn_consultar_usuarios;
        private DataGridView Dgv_consultar_usuarios;
        private Button Btn_editar;
        private DataGridView Dgv_usuarios;
        private Label label5;
        private TextBox Txb_confirmar_contraseña;
        private TextBox Txb_Contraseña;
        private Label label4;
        private Label label3;
        private TextBox TXB_Nombre_nuevo_usuario;
        private Label label2;
        private ComboBox CBX_rol;
        private Button Btn_guardar;
        private GroupBox Gpb_insertar_usuario;
        private Button Btn_editar_rol;
        private Button Btn_guardar_rol;
        private DataGridView Dgv_roles;
        private TextBox Txb_nombre_rol;
        private Label label8;
        private GroupBox Gpb_eliminar_usuarios;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button Btn_eliminar_usuario;
        private GroupBox Gpb_consultar_usuarios;
    }
}