using CapaEntidades.UsuarioSistema;
using CapaNegocios.UsuarioSistema;
using CapaPresentacion.Global;
using CapaPresentacion.UsuarioSistema.RecuperarContraseña;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private readonly Cn_Usuario oCn_Usuario = new();
        private readonly Cn_Rol oCn_Rol = new();

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region MisMetodos

        private void ListarRoles()
        {
            CmbRol.DataSource = oCn_Rol.ConsultarRol();
            CmbRol.DisplayMember = "Nombre";
            CmbRol.ValueMember = "Id";
        }

        private void Ingresar()
        {
            Ce_Usuario oCe_Usuario = new(TxtUsuario.Text, TxtContrasenia.Text, Convert.ToInt32(CmbRol.SelectedValue));

            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtContrasenia.Text))
            {
                MessageBox.Show("Hay campos vacios.");
            }
            else
            {
                if (oCn_Usuario.ConsultarUsuario(oCe_Usuario) == false)
                {
                    MessageBox.Show("El usuario no existe.");
                }
                else
                {
                    switch (oCn_Usuario.ValidarUsuario(oCe_Usuario))
                    {
                        case true:
                            Cp_VarGlobal.NombreUsuario = TxtUsuario.Text;
                            Cp_VarGlobal.idRolUsuario = Convert.ToInt32(CmbRol.SelectedValue);
                            FrmMenuPrincipal MenPrin = new();
                            MenPrin.Show();
                            this.Hide();
                            break;
                        case false:
                            MessageBox.Show("Datos incorrectos.");
                            break;
                    }
                }
            }
        }

        #endregion

        #region PlaceHolder

        private void TxtUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                TxtUsuario.Text = "USUARIO";
            }
        }

        private void TxtContrasenia_MouseEnter(object sender, EventArgs e)
        {
            if (TxtContrasenia.Text == "CONTRASEÑA")
            {
                TxtContrasenia.Text = "";
            }
        }

        private void TxtContrasenia_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtContrasenia.Text))
            {
                TxtContrasenia.Text = "CONTRASEÑA";
            }
        }

        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarContrasenia lol = new FrmRecuperarContrasenia();
            lol.ShowDialog();
        }
    }
}
