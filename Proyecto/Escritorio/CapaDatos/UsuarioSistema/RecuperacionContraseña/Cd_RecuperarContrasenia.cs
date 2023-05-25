namespace CapaDatos.UsuarioSistema.RecuperacionContraseña
{
    public class Cd_RecuperarContrasenia : Cd_EnviarEmail
    {
        public Cd_RecuperarContrasenia()
        {
            senderMail = "soporteSystemTiendita@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
