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

            MessageBox.Show("Se ha enviando a un correo con su nueva contraseña a su correo de la empresa. Por favor espere unos segundos.");

            if (CorreoExiste)
            {
                MessageBox.Show("Su contraseña ha sido reestablecida, por favor revise la bandeja de entrada de su correo." 
                                + "\n" + "Se recomienda cambiar la contraseña tan pronto entre nuevamente al sistema");
            }
            else
            {
                MessageBox.Show("Correo invalido.");
            }
        }
    }
}
