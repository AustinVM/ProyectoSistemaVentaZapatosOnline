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

        private async void BtnIngresar_Click(object sender, EventArgs e)
        {
            bool CorreoExiste = await oCn_Usuario.recuperarContrasenia(TxtCorreo.Text);

            if (CorreoExiste)
            {
                MessageBox.Show("Se ha enviando a una correo con su nueva contraseña a su cooreo de la empresa.");
            }
            else
            {
                MessageBox.Show("Correo no encontrado.");
            }
        }
    }
}
