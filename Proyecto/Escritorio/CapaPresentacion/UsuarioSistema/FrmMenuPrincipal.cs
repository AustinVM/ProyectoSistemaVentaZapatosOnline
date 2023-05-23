using CapaPresentacion.Global;
using CapaPresentacion.Productos;
using CapaPresentacion.UsuarioSistema;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            Permisos();
        }

        #region MisMetodos

        private static void Permisos()
        {
            //switch (Cp_VarGlobal.idRolUsuario) // "Permisos" de los usuarios
            //{
            //    case 2: // Vendedor
            //        
            //        break;
            //    case 3: // Auxiliar
            //        
            //        break;
            //    case 4: // Bodega
            //        
            //        break;
            //}
        }

        private void Abrir(Form hijo)
        {
            this.PnlOpciones.Controls.Clear();
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.PnlOpciones.Controls.Add(hijo);
            hijo.Show();
        }

        #endregion

        private void BtnUsuario_Click(object sender, EventArgs e)
        {

            Abrir(new Frm_Crear_Usuario());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            Abrir(new Frm_Productos());
        }
    }
}
