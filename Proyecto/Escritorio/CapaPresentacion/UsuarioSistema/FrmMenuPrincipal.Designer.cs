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
            panel1 = new Panel();
            BtnProductos = new Button();
            BtnSalir = new Button();
            BtnUsuario = new Button();
            panel_Usuario = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(BtnProductos);
            panel1.Controls.Add(BtnSalir);
            panel1.Controls.Add(BtnUsuario);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 615);
            panel1.TabIndex = 0;
            // 
            // BtnProductos
            // 
            BtnProductos.Location = new Point(45, 142);
            BtnProductos.Name = "Btn_Productos";
            BtnProductos.Size = new Size(136, 23);
            BtnProductos.TabIndex = 3;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = true;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(56, 547);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(136, 23);
            BtnSalir.TabIndex = 2;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnUsuario
            // 
            BtnUsuario.Location = new Point(45, 100);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(136, 23);
            BtnUsuario.TabIndex = 1;
            BtnUsuario.Text = "Usuario";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // panel_Usuario
            // 
            panel_Usuario.BackColor = Color.FromArgb(64, 64, 64);
            panel_Usuario.Dock = DockStyle.Fill;
            panel_Usuario.Location = new Point(250, 0);
            panel_Usuario.Name = "panel_Usuario";
            panel_Usuario.Size = new Size(984, 615);
            panel_Usuario.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1234, 615);
            Controls.Add(panel_Usuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_MenuPrincipal";
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_Usuario;
        private Button BtnUsuario;
        private Button BtnSalir;
        private Button BtnProductos;
    }
}