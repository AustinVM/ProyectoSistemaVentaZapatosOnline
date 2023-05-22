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
            menuStrip1 = new MenuStrip();
            crearNuevoUsuarioToolStripMenuItem = new ToolStripMenuItem();
            crearYEditarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            crearRolesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            Gpb_roles = new GroupBox();
            Btn_editar_rol = new Button();
            Btn_guardar_rol = new Button();
            Dgv_roles = new DataGridView();
            Txb_nombre_rol = new TextBox();
            label8 = new Label();
            Gpb_insertar_usuario = new GroupBox();
            Btn_editar = new Button();
            label2 = new Label();
            Dgv_usuarios = new DataGridView();
            Btn_guardar = new Button();
            label5 = new Label();
            CBX_rol = new ComboBox();
            Txb_confirmar_contraseña = new TextBox();
            TXB_Nombre_nuevo_usuario = new TextBox();
            Txb_Contraseña = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            Dgv_consultar_usuarios = new DataGridView();
            Btn_consultar_usuarios = new Button();
            Cmb_consultar_usuarios_roles = new ComboBox();
            label6 = new Label();
            Gpb_eliminar_usuarios = new GroupBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            Btn_eliminar_usuario = new Button();
            Gpb_consultar_usuarios = new GroupBox();
            menuStrip1.SuspendLayout();
            Gpb_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_roles).BeginInit();
            Gpb_insertar_usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_usuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_consultar_usuarios).BeginInit();
            Gpb_eliminar_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Gpb_consultar_usuarios.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 122, 204);
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearNuevoUsuarioToolStripMenuItem, crearRolesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1216, 29);
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
            crearYEditarUsuariosToolStripMenuItem.Click += crearYEditarUsuariosToolStripMenuItem_Click;
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            consultarUsuariosToolStripMenuItem.Size = new Size(252, 26);
            consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            consultarUsuariosToolStripMenuItem.Click += consultarUsuariosToolStripMenuItem_Click;
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            eliminarUsuariosToolStripMenuItem.Size = new Size(252, 26);
            eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            eliminarUsuariosToolStripMenuItem.Click += eliminarUsuariosToolStripMenuItem_Click;
            // 
            // crearRolesToolStripMenuItem
            // 
            crearRolesToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            crearRolesToolStripMenuItem.Name = "crearRolesToolStripMenuItem";
            crearRolesToolStripMenuItem.Size = new Size(63, 25);
            crearRolesToolStripMenuItem.Text = "Roles";
            crearRolesToolStripMenuItem.Click += crearRolesToolStripMenuItem_Click;
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
            // Gpb_roles
            // 
            Gpb_roles.Controls.Add(Btn_editar_rol);
            Gpb_roles.Controls.Add(Btn_guardar_rol);
            Gpb_roles.Controls.Add(Dgv_roles);
            Gpb_roles.Controls.Add(Txb_nombre_rol);
            Gpb_roles.Controls.Add(label8);
            Gpb_roles.Location = new Point(56, 150);
            Gpb_roles.Name = "Gpb_roles";
            Gpb_roles.Size = new Size(798, 432);
            Gpb_roles.TabIndex = 3;
            Gpb_roles.TabStop = false;
            // 
            // Btn_editar_rol
            // 
            Btn_editar_rol.Location = new Point(230, 108);
            Btn_editar_rol.Name = "Btn_editar_rol";
            Btn_editar_rol.Size = new Size(75, 23);
            Btn_editar_rol.TabIndex = 14;
            Btn_editar_rol.Text = "Editar";
            Btn_editar_rol.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar_rol
            // 
            Btn_guardar_rol.Location = new Point(110, 108);
            Btn_guardar_rol.Name = "Btn_guardar_rol";
            Btn_guardar_rol.Size = new Size(75, 23);
            Btn_guardar_rol.TabIndex = 15;
            Btn_guardar_rol.Text = "Guardar";
            Btn_guardar_rol.UseVisualStyleBackColor = true;
            // 
            // Dgv_roles
            // 
            Dgv_roles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_roles.Location = new Point(177, 161);
            Dgv_roles.Name = "Dgv_roles";
            Dgv_roles.RowTemplate.Height = 25;
            Dgv_roles.Size = new Size(240, 150);
            Dgv_roles.TabIndex = 18;
            // 
            // Txb_nombre_rol
            // 
            Txb_nombre_rol.Location = new Point(404, 48);
            Txb_nombre_rol.Name = "Txb_nombre_rol";
            Txb_nombre_rol.Size = new Size(121, 23);
            Txb_nombre_rol.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(77, 50);
            label8.Name = "label8";
            label8.Size = new Size(324, 20);
            label8.TabIndex = 17;
            label8.Text = "Ingrese Nombre Del Rol Del Trabajador";
            // 
            // Gpb_insertar_usuario
            // 
            Gpb_insertar_usuario.Controls.Add(Btn_editar);
            Gpb_insertar_usuario.Controls.Add(label2);
            Gpb_insertar_usuario.Controls.Add(Dgv_usuarios);
            Gpb_insertar_usuario.Controls.Add(Btn_guardar);
            Gpb_insertar_usuario.Controls.Add(label5);
            Gpb_insertar_usuario.Controls.Add(CBX_rol);
            Gpb_insertar_usuario.Controls.Add(Txb_confirmar_contraseña);
            Gpb_insertar_usuario.Controls.Add(TXB_Nombre_nuevo_usuario);
            Gpb_insertar_usuario.Controls.Add(Txb_Contraseña);
            Gpb_insertar_usuario.Controls.Add(label3);
            Gpb_insertar_usuario.Controls.Add(label4);
            Gpb_insertar_usuario.Location = new Point(56, 156);
            Gpb_insertar_usuario.Name = "Gpb_insertar_usuario";
            Gpb_insertar_usuario.Size = new Size(798, 432);
            Gpb_insertar_usuario.TabIndex = 15;
            Gpb_insertar_usuario.TabStop = false;
            // 
            // Btn_editar
            // 
            Btn_editar.Location = new Point(206, 367);
            Btn_editar.Name = "Btn_editar";
            Btn_editar.Size = new Size(75, 23);
            Btn_editar.TabIndex = 9;
            Btn_editar.Text = "Editar";
            Btn_editar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Del Usuario";
            // 
            // Dgv_usuarios
            // 
            Dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_usuarios.Location = new Point(419, 141);
            Dgv_usuarios.Name = "Dgv_usuarios";
            Dgv_usuarios.RowTemplate.Height = 25;
            Dgv_usuarios.Size = new Size(337, 150);
            Dgv_usuarios.TabIndex = 8;
            // 
            // Btn_guardar
            // 
            Btn_guardar.Location = new Point(69, 367);
            Btn_guardar.Name = "Btn_guardar";
            Btn_guardar.Size = new Size(75, 23);
            Btn_guardar.TabIndex = 0;
            Btn_guardar.Text = "Guardar";
            Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(25, 283);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 7;
            label5.Text = "Cargo del Usuario";
            // 
            // CBX_rol
            // 
            CBX_rol.FormattingEnabled = true;
            CBX_rol.Location = new Point(232, 281);
            CBX_rol.Name = "CBX_rol";
            CBX_rol.Size = new Size(121, 23);
            CBX_rol.TabIndex = 1;
            // 
            // Txb_confirmar_contraseña
            // 
            Txb_confirmar_contraseña.Location = new Point(232, 209);
            Txb_confirmar_contraseña.Name = "Txb_confirmar_contraseña";
            Txb_confirmar_contraseña.Size = new Size(121, 23);
            Txb_confirmar_contraseña.TabIndex = 6;
            // 
            // TXB_Nombre_nuevo_usuario
            // 
            TXB_Nombre_nuevo_usuario.Location = new Point(232, 36);
            TXB_Nombre_nuevo_usuario.Name = "TXB_Nombre_nuevo_usuario";
            TXB_Nombre_nuevo_usuario.Size = new Size(121, 23);
            TXB_Nombre_nuevo_usuario.TabIndex = 2;
            // 
            // Txb_Contraseña
            // 
            Txb_Contraseña.Location = new Point(232, 129);
            Txb_Contraseña.Name = "Txb_Contraseña";
            Txb_Contraseña.Size = new Size(121, 23);
            Txb_Contraseña.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 127);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 3;
            label3.Text = "Ingrese una Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 207);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 4;
            label4.Text = "Confirme la Contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 106);
            panel1.TabIndex = 1;
            // 
            // Dgv_consultar_usuarios
            // 
            Dgv_consultar_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_consultar_usuarios.Location = new Point(16, 114);
            Dgv_consultar_usuarios.Name = "Dgv_consultar_usuarios";
            Dgv_consultar_usuarios.RowTemplate.Height = 25;
            Dgv_consultar_usuarios.Size = new Size(769, 150);
            Dgv_consultar_usuarios.TabIndex = 0;
            // 
            // Btn_consultar_usuarios
            // 
            Btn_consultar_usuarios.Location = new Point(427, 65);
            Btn_consultar_usuarios.Name = "Btn_consultar_usuarios";
            Btn_consultar_usuarios.Size = new Size(75, 23);
            Btn_consultar_usuarios.TabIndex = 1;
            Btn_consultar_usuarios.Text = "Consultar";
            Btn_consultar_usuarios.UseVisualStyleBackColor = true;
            // 
            // Cmb_consultar_usuarios_roles
            // 
            Cmb_consultar_usuarios_roles.FormattingEnabled = true;
            Cmb_consultar_usuarios_roles.Location = new Point(260, 65);
            Cmb_consultar_usuarios_roles.Name = "Cmb_consultar_usuarios_roles";
            Cmb_consultar_usuarios_roles.Size = new Size(121, 23);
            Cmb_consultar_usuarios_roles.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(127, 63);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 3;
            label6.Text = "Filtar por Roles";
            // 
            // Gpb_eliminar_usuarios
            // 
            Gpb_eliminar_usuarios.Controls.Add(label7);
            Gpb_eliminar_usuarios.Controls.Add(comboBox1);
            Gpb_eliminar_usuarios.Controls.Add(dataGridView1);
            Gpb_eliminar_usuarios.Controls.Add(Btn_eliminar_usuario);
            Gpb_eliminar_usuarios.Location = new Point(56, 150);
            Gpb_eliminar_usuarios.Name = "Gpb_eliminar_usuarios";
            Gpb_eliminar_usuarios.Size = new Size(798, 426);
            Gpb_eliminar_usuarios.TabIndex = 16;
            Gpb_eliminar_usuarios.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(157, 55);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 3;
            label7.Text = "Filtar por Roles";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(290, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(668, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Btn_eliminar_usuario
            // 
            Btn_eliminar_usuario.Location = new Point(571, 57);
            Btn_eliminar_usuario.Name = "Btn_eliminar_usuario";
            Btn_eliminar_usuario.Size = new Size(75, 23);
            Btn_eliminar_usuario.TabIndex = 1;
            Btn_eliminar_usuario.Text = "Eliminar";
            Btn_eliminar_usuario.UseVisualStyleBackColor = true;
            // 
            // Gpb_consultar_usuarios
            // 
            Gpb_consultar_usuarios.Controls.Add(label6);
            Gpb_consultar_usuarios.Controls.Add(Cmb_consultar_usuarios_roles);
            Gpb_consultar_usuarios.Controls.Add(Dgv_consultar_usuarios);
            Gpb_consultar_usuarios.Controls.Add(Btn_consultar_usuarios);
            Gpb_consultar_usuarios.Location = new Point(56, 150);
            Gpb_consultar_usuarios.Name = "Gpb_consultar_usuarios";
            Gpb_consultar_usuarios.Size = new Size(798, 438);
            Gpb_consultar_usuarios.TabIndex = 17;
            Gpb_consultar_usuarios.TabStop = false;
            // 
            // Frm_Crear_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1216, 742);
            Controls.Add(panel1);
            Controls.Add(Gpb_insertar_usuario);
            Controls.Add(Gpb_roles);
            Controls.Add(Gpb_consultar_usuarios);
            Controls.Add(Gpb_eliminar_usuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Crear_Usuario";
            Text = "Fm_Crear_Usuario";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Gpb_roles.ResumeLayout(false);
            Gpb_roles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_roles).EndInit();
            Gpb_insertar_usuario.ResumeLayout(false);
            Gpb_insertar_usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_usuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_consultar_usuarios).EndInit();
            Gpb_eliminar_usuarios.ResumeLayout(false);
            Gpb_eliminar_usuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Gpb_consultar_usuarios.ResumeLayout(false);
            Gpb_consultar_usuarios.PerformLayout();
            ResumeLayout(false);
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