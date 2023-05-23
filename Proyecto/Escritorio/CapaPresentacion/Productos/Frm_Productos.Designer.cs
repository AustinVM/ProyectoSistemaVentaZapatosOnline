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
            this.panel_Usuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbColor = new System.Windows.Forms.ComboBox();
            this.CmbColeccion = new System.Windows.Forms.ComboBox();
            this.CmbMaterial = new System.Windows.Forms.ComboBox();
            this.CmbTipoCalzado = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.panel_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Usuario
            // 
            this.panel_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Usuario.Controls.Add(this.BtnEditar);
            this.panel_Usuario.Controls.Add(this.BtnAgregar);
            this.panel_Usuario.Controls.Add(this.textBox1);
            this.panel_Usuario.Controls.Add(this.CmbTipoCalzado);
            this.panel_Usuario.Controls.Add(this.CmbMaterial);
            this.panel_Usuario.Controls.Add(this.CmbColeccion);
            this.panel_Usuario.Controls.Add(this.CmbColor);
            this.panel_Usuario.Controls.Add(this.label5);
            this.panel_Usuario.Controls.Add(this.label4);
            this.panel_Usuario.Controls.Add(this.label3);
            this.panel_Usuario.Controls.Add(this.label2);
            this.panel_Usuario.Controls.Add(this.label1);
            this.panel_Usuario.Controls.Add(this.panel1);
            this.panel_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Usuario.Location = new System.Drawing.Point(0, 0);
            this.panel_Usuario.Name = "panel_Usuario";
            this.panel_Usuario.Size = new System.Drawing.Size(939, 453);
            this.panel_Usuario.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 106);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Producto";
       
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Calzado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Coleccion";
            // 
            // CmbColor
            // 
            this.CmbColor.FormattingEnabled = true;
            this.CmbColor.Location = new System.Drawing.Point(229, 189);
            this.CmbColor.Name = "CmbColor";
            this.CmbColor.Size = new System.Drawing.Size(121, 23);
            this.CmbColor.TabIndex = 8;
            // 
            // CmbColeccion
            // 
            this.CmbColeccion.FormattingEnabled = true;
            this.CmbColeccion.Location = new System.Drawing.Point(229, 218);
            this.CmbColeccion.Name = "CmbColeccion";
            this.CmbColeccion.Size = new System.Drawing.Size(121, 23);
            this.CmbColeccion.TabIndex = 9;
            // 
            // CmbMaterial
            // 
            this.CmbMaterial.FormattingEnabled = true;
            this.CmbMaterial.Location = new System.Drawing.Point(229, 253);
            this.CmbMaterial.Name = "CmbMaterial";
            this.CmbMaterial.Size = new System.Drawing.Size(121, 23);
            this.CmbMaterial.TabIndex = 10;
            // 
            // CmbTipoCalzado
            // 
            this.CmbTipoCalzado.FormattingEnabled = true;
            this.CmbTipoCalzado.Location = new System.Drawing.Point(229, 286);
            this.CmbTipoCalzado.Name = "CmbTipoCalzado";
            this.CmbTipoCalzado.Size = new System.Drawing.Size(121, 23);
            this.CmbTipoCalzado.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 12;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(352, 341);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(447, 341);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // Frm_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 453);
            this.Controls.Add(this.panel_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Productos";
            this.Text = "Frm_Productos";
            this.panel_Usuario.ResumeLayout(false);
            this.panel_Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Usuario;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnEditar;
        private Button BtnAgregar;
        private TextBox textBox1;
        private ComboBox CmbTipoCalzado;
        private ComboBox CmbMaterial;
        private ComboBox CmbColeccion;
        private ComboBox CmbColor;
    }
}