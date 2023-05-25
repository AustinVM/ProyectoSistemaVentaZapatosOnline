using CapaNegocios.UsuarioSistema;

namespace CapaPresentacion.UsuarioSistema.RecuperarContraseña
{
    public partial class FrmRecuperarContrasenia : Form
    {
        Cn_Usuario oCn_Usuario = new Cn_Usuario();

        public FrmRecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            oCn_Usuario.recuperarContrasenia(TxtUsuario.Text);
        }
    }
}
