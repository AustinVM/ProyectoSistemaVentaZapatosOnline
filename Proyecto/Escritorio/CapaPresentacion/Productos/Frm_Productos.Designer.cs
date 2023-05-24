namespace CapaPresentacion.Productos
{
    partial class Frm_Productos
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.CmbTipoCalzado = new System.Windows.Forms.ComboBox();
            this.CmbMaterial = new System.Windows.Forms.ComboBox();
            this.CmbColeccion = new System.Windows.Forms.ComboBox();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.PbImagenProducto = new System.Windows.Forms.PictureBox();
            this.BtnElegirImagen = new System.Windows.Forms.Button();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DgwProductos = new System.Windows.Forms.DataGridView();
            this.BtnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(151, 495);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(94, 30);
            this.BtnEditar.TabIndex = 26;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(41, 495);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(86, 30);
            this.BtnAgregar.TabIndex = 25;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(157, 158);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(121, 23);
            this.TxtNombreProducto.TabIndex = 24;
            // 
            // CmbTipoCalzado
            // 
            this.CmbTipoCalzado.FormattingEnabled = true;
            this.CmbTipoCalzado.Location = new System.Drawing.Point(151, 287);
            this.CmbTipoCalzado.Name = "CmbTipoCalzado";
            this.CmbTipoCalzado.Size = new System.Drawing.Size(121, 23);
            this.CmbTipoCalzado.TabIndex = 23;
            // 
            // CmbMaterial
            // 
            this.CmbMaterial.FormattingEnabled = true;
            this.CmbMaterial.Location = new System.Drawing.Point(151, 426);
            this.CmbMaterial.Name = "CmbMaterial";
            this.CmbMaterial.Size = new System.Drawing.Size(121, 23);
            this.CmbMaterial.TabIndex = 22;
            // 
            // CmbColeccion
            // 
            this.CmbColeccion.FormattingEnabled = true;
            this.CmbColeccion.Location = new System.Drawing.Point(151, 206);
            this.CmbColeccion.Name = "CmbColeccion";
            this.CmbColeccion.Size = new System.Drawing.Size(121, 23);
            this.CmbColeccion.TabIndex = 21;
            // 
            // CmbColor
            // 
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Location = new System.Drawing.Point(151, 365);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(121, 23);
            this.CmbColor.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Coleccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo Calzado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 100);
            this.panel1.TabIndex = 27;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(306, 106);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(127, 23);
            this.TxtCodigo.TabIndex = 35;
            this.TxtCodigo.Text = ".";
            // 
            // PbImagenProducto
            // 
            this.PbImagenProducto.Location = new System.Drawing.Point(330, 138);
            this.PbImagenProducto.Name = "PbImagenProducto";
            this.PbImagenProducto.Size = new System.Drawing.Size(239, 150);
            this.PbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImagenProducto.TabIndex = 30;
            this.PbImagenProducto.TabStop = false;
            // 
            // BtnElegirImagen
            // 
            this.BtnElegirImagen.Location = new System.Drawing.Point(385, 335);
            this.BtnElegirImagen.Name = "BtnElegirImagen";
            this.BtnElegirImagen.Size = new System.Drawing.Size(124, 34);
            this.BtnElegirImagen.TabIndex = 31;
            this.BtnElegirImagen.Text = "Elegir Imagen";
            this.BtnElegirImagen.UseVisualStyleBackColor = true;
            this.BtnElegirImagen.Click += new System.EventHandler(this.BtnElegirImagen_Click);
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(398, 294);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(100, 23);
            this.TxtRuta.TabIndex = 32;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DgwProductos
            // 
            this.DgwProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProductos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DgwProductos.Location = new System.Drawing.Point(595, 110);
            this.DgwProductos.Name = "DgwProductos";
            this.DgwProductos.RowTemplate.Height = 25;
            this.DgwProductos.Size = new System.Drawing.Size(334, 353);
            this.DgwProductos.TabIndex = 33;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(708, 480);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(124, 34);
            this.BtnConsulta.TabIndex = 34;
            this.BtnConsulta.Text = "ConsultaProductos";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(941, 567);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.DgwProductos);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.BtnElegirImagen);
            this.Controls.Add(this.PbImagenProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.CmbTipoCalzado);
            this.Controls.Add(this.CmbMaterial);
            this.Controls.Add(this.CmbColeccion);
            this.Controls.Add(this.CmbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.Load += new System.EventHandler(this.Frm_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnEditar;
        private Button BtnAgregar;
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
        private Button BtnConsulta;
        private TextBox TxtCodigo;
    }
}