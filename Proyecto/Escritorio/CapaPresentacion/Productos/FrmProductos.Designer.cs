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
            TxtNombreProducto = new TextBox();
            CmbTipoCalzado = new ComboBox();
            CmbMaterial = new ComboBox();
            CmbColeccion = new ComboBox();
            CmbColor = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            PbImagenProducto = new PictureBox();
            BtnElegirImagen = new Button();
            TxtRuta = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            DgwProductos = new DataGridView();
            BtnAgregar = new Button();
            BtnEditar = new Button();
            BtnConsulta = new Button();
            ((System.ComponentModel.ISupportInitialize)PbImagenProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgwProductos).BeginInit();
            SuspendLayout();
            // 
            // TxtNombreProducto
            // 
            TxtNombreProducto.Location = new Point(160, 174);
            TxtNombreProducto.Name = "TxtNombreProducto";
            TxtNombreProducto.Size = new Size(121, 23);
            TxtNombreProducto.TabIndex = 24;
            // 
            // CmbTipoCalzado
            // 
            CmbTipoCalzado.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipoCalzado.FormattingEnabled = true;
            CmbTipoCalzado.Location = new Point(160, 308);
            CmbTipoCalzado.Name = "CmbTipoCalzado";
            CmbTipoCalzado.Size = new Size(121, 23);
            CmbTipoCalzado.TabIndex = 23;
            // 
            // CmbMaterial
            // 
            CmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMaterial.FormattingEnabled = true;
            CmbMaterial.Location = new Point(160, 442);
            CmbMaterial.Name = "CmbMaterial";
            CmbMaterial.Size = new Size(121, 23);
            CmbMaterial.TabIndex = 22;
            // 
            // CmbColeccion
            // 
            CmbColeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbColeccion.FormattingEnabled = true;
            CmbColeccion.Location = new Point(160, 241);
            CmbColeccion.Name = "CmbColeccion";
            CmbColeccion.Size = new Size(121, 23);
            CmbColeccion.TabIndex = 21;
            // 
            // CmbColor
            // 
            CmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbColor.FormattingEnabled = true;
            CmbColor.Location = new Point(160, 375);
            CmbColor.Name = "CmbColor";
            CmbColor.Size = new Size(121, 23);
            CmbColor.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(70, 241);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 19;
            label5.Text = "Coleccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(82, 443);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 18;
            label4.Text = "Material";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(46, 308);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 17;
            label3.Text = "Tipo Calzado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(103, 374);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 16;
            label2.Text = "Color";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(142, 18);
            label1.TabIndex = 15;
            label1.Text = "Nombre Producto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 100);
            panel1.TabIndex = 27;
            // 
            // PbImagenProducto
            // 
            PbImagenProducto.Location = new Point(393, 158);
            PbImagenProducto.Name = "PbImagenProducto";
            PbImagenProducto.Size = new Size(239, 150);
            PbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbImagenProducto.TabIndex = 30;
            PbImagenProducto.TabStop = false;
            // 
            // BtnElegirImagen
            // 
            BtnElegirImagen.Location = new Point(393, 415);
            BtnElegirImagen.Name = "BtnElegirImagen";
            BtnElegirImagen.Size = new Size(124, 34);
            BtnElegirImagen.TabIndex = 31;
            BtnElegirImagen.Text = "Elegir Imagen";
            BtnElegirImagen.UseVisualStyleBackColor = true;
            BtnElegirImagen.Click += BtnElegirImagen_Click;
            // 
            // TxtRuta
            // 
            TxtRuta.Location = new Point(393, 375);
            TxtRuta.Name = "TxtRuta";
            TxtRuta.Size = new Size(124, 23);
            TxtRuta.TabIndex = 32;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // DgwProductos
            // 
            DgwProductos.BackgroundColor = SystemColors.ButtonFace;
            DgwProductos.BorderStyle = BorderStyle.Fixed3D;
            DgwProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgwProductos.GridColor = SystemColors.ButtonFace;
            DgwProductos.Location = new Point(644, 158);
            DgwProductos.Name = "DgwProductos";
            DgwProductos.RowTemplate.Height = 25;
            DgwProductos.Size = new Size(334, 409);
            DgwProductos.TabIndex = 33;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnAgregar.BackColor = Color.FromArgb(40, 40, 40);
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.Silver;
            BtnAgregar.Location = new Point(16, 573);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(165, 30);
            BtnAgregar.TabIndex = 36;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnEditar.BackColor = Color.FromArgb(40, 40, 40);
            BtnEditar.Cursor = Cursors.Hand;
            BtnEditar.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnEditar.FlatAppearance.BorderSize = 0;
            BtnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnEditar.FlatStyle = FlatStyle.Flat;
            BtnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditar.ForeColor = Color.Silver;
            BtnEditar.Location = new Point(187, 573);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(165, 30);
            BtnEditar.TabIndex = 37;
            BtnEditar.Text = "EDITAR";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnConsulta
            // 
            BtnConsulta.BackColor = Color.FromArgb(40, 40, 40);
            BtnConsulta.Cursor = Cursors.Hand;
            BtnConsulta.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnConsulta.FlatAppearance.BorderSize = 0;
            BtnConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnConsulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnConsulta.FlatStyle = FlatStyle.Flat;
            BtnConsulta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConsulta.ForeColor = Color.Silver;
            BtnConsulta.Location = new Point(813, 573);
            BtnConsulta.Name = "BtnConsulta";
            BtnConsulta.Size = new Size(165, 30);
            BtnConsulta.TabIndex = 38;
            BtnConsulta.Text = "CONSULTAR";
            BtnConsulta.UseVisualStyleBackColor = false;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(990, 615);
            Controls.Add(BtnConsulta);
            Controls.Add(BtnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(DgwProductos);
            Controls.Add(TxtRuta);
            Controls.Add(BtnElegirImagen);
            Controls.Add(PbImagenProducto);
            Controls.Add(panel1);
            Controls.Add(TxtNombreProducto);
            Controls.Add(CmbTipoCalzado);
            Controls.Add(CmbMaterial);
            Controls.Add(CmbColeccion);
            Controls.Add(CmbColor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProductos";
            Text = "Frm_Productos";
            Load += Frm_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)PbImagenProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgwProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtNombreProducto;
        private ComboBox CmbTipoCalzado;
        private ComboBox CmbMaterial;
        private ComboBox CmbColeccion;
        private ComboBox CmbColor;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox PbImagenProducto;
        private Button BtnElegirImagen;
        private TextBox TxtRuta;
        private OpenFileDialog openFileDialog1;
        private DataGridView DgwProductos;
        private Button BtnAgregar;
        private Button BtnEditar;
        private Button BtnConsulta;
    }
}