namespace CapaPresentacion.UsuarioSistema.RecuperarContraseña
{
    partial class FrmRecuperarContrasenia
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
            TxtCorreo = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            BtnIngresar = new Button();
            SuspendLayout();
            // 
            // TxtCorreo
            // 
            TxtCorreo.BackColor = Color.FromArgb(15, 15, 15);
            TxtCorreo.BorderStyle = BorderStyle.None;
            TxtCorreo.Cursor = Cursors.IBeam;
            TxtCorreo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCorreo.ForeColor = Color.FromArgb(130, 130, 130);
            TxtCorreo.Location = new Point(21, 159);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(410, 13);
            TxtCorreo.TabIndex = 6;
            TxtCorreo.Text = "CORREO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(18, 160);
            label2.Name = "label2";
            label2.Size = new Size(397, 15);
            label2.TabIndex = 8;
            label2.Text = "______________________________________________________________________________";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 68);
            panel1.TabIndex = 9;
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(40, 40, 40);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderColor = Color.FromArgb(15, 15, 15);
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.Silver;
            BtnIngresar.Location = new Point(21, 271);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(394, 35);
            BtnIngresar.TabIndex = 10;
            BtnIngresar.Text = "RECUPERAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // FrmRecuperarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(440, 375);
            Controls.Add(BtnIngresar);
            Controls.Add(panel1);
            Controls.Add(TxtCorreo);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecuperarContrasenia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRecuperarContrasenia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCorreo;
        private Label label2;
        private Panel panel1;
        private Button BtnIngresar;
    }
}