namespace CapaPresentacion.Productos
{
    partial class FrmProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearYEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Gpb_Consultar_Producto = new System.Windows.Forms.GroupBox();
            this.BtnConsultarProducto = new System.Windows.Forms.Button();
            this.PbConsultarProducto = new System.Windows.Forms.PictureBox();
            this.DgwConsultarProducto = new System.Windows.Forms.DataGridView();
            this.PbImagenProducto = new System.Windows.Forms.PictureBox();
            this.BtnElegirImagen = new System.Windows.Forms.Button();
            this.OfdElegirImagen = new System.Windows.Forms.OpenFileDialog();
            this.DgwProductos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.Gpb_insertar_Producto = new System.Windows.Forms.GroupBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.CmbTipoCalzado = new System.Windows.Forms.ComboBox();
            this.CmbMaterial = new System.Windows.Forms.ComboBox();
            this.CmbColeccion = new System.Windows.Forms.ComboBox();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Gpb_Consultar_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConsultarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwConsultarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).BeginInit();
            this.Gpb_insertar_Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.Gpb_Consultar_Producto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 100);
            this.panel1.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarProductosToolStripMenuItem
            // 
            this.consultarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearYEditarToolStripMenuItem,
            this.Consultar});
            this.consultarProductosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consultarProductosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.consultarProductosToolStripMenuItem.Name = "consultarProductosToolStripMenuItem";
            this.consultarProductosToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.consultarProductosToolStripMenuItem.Text = "Productos";
            // 
            // crearYEditarToolStripMenuItem
            // 
            this.crearYEditarToolStripMenuItem.Name = "crearYEditarToolStripMenuItem";
            this.crearYEditarToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.crearYEditarToolStripMenuItem.Text = "Crear, Editar y Eliminar Productos";
            this.crearYEditarToolStripMenuItem.Click += new System.EventHandler(this.crearYEditarToolStripMenuItem_Click);
            // 
            // Consultar
            // 
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(334, 26);
            this.Consultar.Text = "Consultar Productos";
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Gpb_Consultar_Producto
            // 
            this.Gpb_Consultar_Producto.Controls.Add(this.BtnConsultarProducto);
            this.Gpb_Consultar_Producto.Controls.Add(this.PbConsultarProducto);
            this.Gpb_Consultar_Producto.Controls.Add(this.DgwConsultarProducto);
            this.Gpb_Consultar_Producto.Location = new System.Drawing.Point(3, 106);
            this.Gpb_Consultar_Producto.Name = "Gpb_Consultar_Producto";
            this.Gpb_Consultar_Producto.Size = new System.Drawing.Size(949, 478);
            this.Gpb_Consultar_Producto.TabIndex = 1;
            this.Gpb_Consultar_Producto.TabStop = false;
            // 
            // BtnConsultarProducto
            // 
            this.BtnConsultarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConsultarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnConsultarProducto.FlatAppearance.BorderSize = 0;
            this.BtnConsultarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnConsultarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConsultarProducto.ForeColor = System.Drawing.Color.Silver;
            this.BtnConsultarProducto.Location = new System.Drawing.Point(507, 49);
            this.BtnConsultarProducto.Name = "BtnConsultarProducto";
            this.BtnConsultarProducto.Size = new System.Drawing.Size(165, 30);
            this.BtnConsultarProducto.TabIndex = 39;
            this.BtnConsultarProducto.Text = "CONSULTAR";
            this.BtnConsultarProducto.UseVisualStyleBackColor = false;
            this.BtnConsultarProducto.Click += new System.EventHandler(this.BtnConsultarProducto_Click);
            // 
            // PbConsultarProducto
            // 
            this.PbConsultarProducto.Location = new System.Drawing.Point(694, 22);
            this.PbConsultarProducto.Name = "PbConsultarProducto";
            this.PbConsultarProducto.Size = new System.Drawing.Size(165, 181);
            this.PbConsultarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbConsultarProducto.TabIndex = 35;
            this.PbConsultarProducto.TabStop = false;
            // 
            // DgwConsultarProducto
            // 
            this.DgwConsultarProducto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwConsultarProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgwConsultarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwConsultarProducto.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwConsultarProducto.Location = new System.Drawing.Point(44, 215);
            this.DgwConsultarProducto.Name = "DgwConsultarProducto";
            this.DgwConsultarProducto.RowTemplate.Height = 25;
            this.DgwConsultarProducto.Size = new System.Drawing.Size(826, 251);
            this.DgwConsultarProducto.TabIndex = 34;
            // 
            // PbImagenProducto
            // 
            this.PbImagenProducto.Location = new System.Drawing.Point(343, 58);
            this.PbImagenProducto.Name = "PbImagenProducto";
            this.PbImagenProducto.Size = new System.Drawing.Size(210, 210);
            this.PbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagenProducto.TabIndex = 30;
            this.PbImagenProducto.TabStop = false;
            // 
            // BtnElegirImagen
            // 
            this.BtnElegirImagen.Location = new System.Drawing.Point(386, 344);
            this.BtnElegirImagen.Name = "BtnElegirImagen";
            this.BtnElegirImagen.Size = new System.Drawing.Size(124, 34);
            this.BtnElegirImagen.TabIndex = 31;
            this.BtnElegirImagen.Text = "Elegir Imagen";
            this.BtnElegirImagen.UseVisualStyleBackColor = true;
            this.BtnElegirImagen.Click += new System.EventHandler(this.BtnElegirImagen_Click);
            // 
            // OfdElegirImagen
            // 
            this.OfdElegirImagen.FileName = "openFileDialog1";
            // 
            // DgwProductos
            // 
            this.DgwProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProductos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwProductos.Location = new System.Drawing.Point(599, 58);
            this.DgwProductos.Name = "DgwProductos";
            this.DgwProductos.RowTemplate.Height = 25;
            this.DgwProductos.Size = new System.Drawing.Size(379, 409);
            this.DgwProductos.TabIndex = 33;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.Color.Silver;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 473);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(165, 30);
            this.BtnAgregar.TabIndex = 36;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.Color.Silver;
            this.BtnEditar.Location = new System.Drawing.Point(190, 473);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(165, 30);
            this.BtnEditar.TabIndex = 37;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConsulta.ForeColor = System.Drawing.Color.Silver;
            this.BtnConsulta.Location = new System.Drawing.Point(813, 473);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(165, 30);
            this.BtnConsulta.TabIndex = 38;
            this.BtnConsulta.Text = "CONSULTAR";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarProducto.ForeColor = System.Drawing.Color.Silver;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(361, 473);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(165, 30);
            this.BtnEliminarProducto.TabIndex = 39;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // Gpb_insertar_Producto
            // 
            this.Gpb_insertar_Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gpb_insertar_Producto.Controls.Add(this.TxtNombreProducto);
            this.Gpb_insertar_Producto.Controls.Add(this.BtnElegirImagen);
            this.Gpb_insertar_Producto.Controls.Add(this.BtnAgregar);
            this.Gpb_insertar_Producto.Controls.Add(this.BtnEditar);
            this.Gpb_insertar_Producto.Controls.Add(this.PbImagenProducto);
            this.Gpb_insertar_Producto.Controls.Add(this.BtnEliminarProducto);
            this.Gpb_insertar_Producto.Controls.Add(this.CmbTipoCalzado);
            this.Gpb_insertar_Producto.Controls.Add(this.BtnConsulta);
            this.Gpb_insertar_Producto.Controls.Add(this.CmbMaterial);
            this.Gpb_insertar_Producto.Controls.Add(this.CmbColeccion);
            this.Gpb_insertar_Producto.Controls.Add(this.CmbColor);
            this.Gpb_insertar_Producto.Controls.Add(this.DgwProductos);
            this.Gpb_insertar_Producto.Controls.Add(this.label6);
            this.Gpb_insertar_Producto.Controls.Add(this.label7);
            this.Gpb_insertar_Producto.Controls.Add(this.label8);
            this.Gpb_insertar_Producto.Controls.Add(this.label9);
            this.Gpb_insertar_Producto.Controls.Add(this.label10);
            this.Gpb_insertar_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gpb_insertar_Producto.Location = new System.Drawing.Point(0, 100);
            this.Gpb_insertar_Producto.Name = "Gpb_insertar_Producto";
            this.Gpb_insertar_Producto.Size = new System.Drawing.Size(990, 515);
            this.Gpb_insertar_Producto.TabIndex = 40;
            this.Gpb_insertar_Producto.TabStop = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(155, 83);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(121, 23);
            this.TxtNombreProducto.TabIndex = 34;
            // 
            // CmbTipoCalzado
            // 
            this.CmbTipoCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoCalzado.FormattingEnabled = true;
            this.CmbTipoCalzado.Location = new System.Drawing.Point(155, 217);
            this.CmbTipoCalzado.Name = "CmbTipoCalzado";
            this.CmbTipoCalzado.Size = new System.Drawing.Size(121, 23);
            this.CmbTipoCalzado.TabIndex = 33;
            // 
            // CmbMaterial
            // 
            this.CmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMaterial.FormattingEnabled = true;
            this.CmbMaterial.Location = new System.Drawing.Point(155, 351);
            this.CmbMaterial.Name = "CmbMaterial";
            this.CmbMaterial.Size = new System.Drawing.Size(121, 23);
            this.CmbMaterial.TabIndex = 32;
            // 
            // CmbColeccion
            // 
            this.CmbColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbColeccion.FormattingEnabled = true;
            this.CmbColeccion.Location = new System.Drawing.Point(155, 150);
            this.CmbColeccion.Name = "CmbColeccion";
            this.CmbColeccion.Size = new System.Drawing.Size(121, 23);
            this.CmbColeccion.TabIndex = 31;
            // 
            // CmbColor
            // 
            this.CmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Location = new System.Drawing.Point(155, 284);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(121, 23);
            this.CmbColor.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(65, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Coleccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(77, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Material";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(41, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipo Calzado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(98, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(7, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nombre Producto";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(990, 615);
            this.Controls.Add(this.Gpb_insertar_Producto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProductos";
            this.Text = "Frm_Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gpb_Consultar_Producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbConsultarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwConsultarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).EndInit();
            this.Gpb_insertar_Producto.ResumeLayout(false);
            this.Gpb_insertar_Producto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private PictureBox PbImagenProducto;
        private Button BtnElegirImagen;
        private OpenFileDialog OfdElegirImagen;
        private DataGridView DgwProductos;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnConsulta;
        private Button BtnEliminarProducto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultarProductosToolStripMenuItem;
        private ToolStripMenuItem crearYEditarToolStripMenuItem;
        private ToolStripMenuItem Consultar;
        private GroupBox Gpb_insertar_Producto;
        private TextBox TxtNombreProducto;
        private ComboBox CmbTipoCalzado;
        private ComboBox CmbMaterial;
        private ComboBox CmbColeccion;
        private ComboBox CmbColor;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox Gpb_Consultar_Producto;
        private Button BtnConsultarProducto;
        private PictureBox PbConsultarProducto;
        private DataGridView DgwConsultarProducto;
    }
}